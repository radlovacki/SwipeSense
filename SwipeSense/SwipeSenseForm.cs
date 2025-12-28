using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SwipeSense
{
    public partial class SwipeSenseForm : Form
    {
        private readonly StringBuilder _buffer = new();
        byte[]? bytes;

        public SwipeSenseForm()
        {
            InitializeComponent();
        }

        private void SwipeSenseForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ProcessSwipe(_buffer.ToString());
                this.bytes = Encoding.ASCII.GetBytes(_buffer.ToString());
                _buffer.Clear();
                e.Handled = true;
                return;
            }
            _buffer.Append(e.KeyChar);
        }

        private void ProcessSwipe(string buffer)
        {
            Parser parser = new Parser(buffer);
            txtTracks.Text = buffer;
            if (parser.Track1 == null)
                return;
            Track1 t1 = parser.Track1;
            txtTrack1.Text = parser.Track1Raw ?? string.Empty;
            txtTrack2.Text = parser.Track2Raw ?? string.Empty;
            txtTrack3.Text = parser.Track3Raw ?? string.Empty;

            txtStx.Text = t1.StartSentinel.ToString();
            txtFormatCode.Text = t1.FormatCode.ToString();
            txtFormatCodeDescription.Text = t1.FormatDescription;

            string pan = t1.PrimaryAccountNumber ?? string.Empty;
            StringBuilder formatted = new StringBuilder();
            for (int i = 0; i < pan.Length; i++)
            {
                formatted.Append(pan[i]);
                if ((i + 1) % 4 == 0 && (i + 1) != pan.Length)
                {
                    formatted.Append(" ");
                }
            }
            txtPrimaryAccountNumber.Text = formatted.ToString();

            if (t1.LuhnValid)
            {
                txtPrimaryAccountNumberValidated.ForeColor = System.Drawing.Color.Green;
                txtPrimaryAccountNumberValidated.Text = "Valid";
            }
            else
            {
                txtPrimaryAccountNumberValidated.ForeColor = System.Drawing.Color.Red;
                txtPrimaryAccountNumberValidated.Text = "Invalid";
            }

            var repo = new CardPatternRepository("card_patterns_enhanced.json");
            if (repo.IsValidPAN(pan))
            {
                txtBrand.Text = repo.FindByPAN(pan)?.Name ?? "Unknown";
                txtRegion.Text = repo.FindByPAN(pan)?.Region + "/" + repo.FindByPAN(pan)?.Country;
                txtType.Text = (repo.FindByPAN(pan)?.Type != null && repo.FindByPAN(pan)!.Type.Count > 0)
                    ? string.Join(", ", repo.FindByPAN(pan)!.Type) : "Unknown";
                txtIso.Text = (repo.FindByPAN(pan)?.ISOStandards != null)
                    ? string.Join(", ", repo.FindByPAN(pan)!.ISOStandards) : "Unknown";
                txtCvv.Text = repo.FindByPAN(pan)?.CVVLength.ToString() ?? "Unknown";
            }
            
            txtSurname.Text = t1.Surname ?? string.Empty;
            txtFirstName.Text = t1.FirstName ?? string.Empty;
            txtMiddleName.Text = t1.MiddleName ?? string.Empty;
            txtTitle.Text = t1.Title ?? string.Empty;

            txtDate.Text = (string.Concat(t1.ExpirationDate.AsSpan(2, 2), "/", t1.ExpirationDate.AsSpan(0, 2))) ?? string.Empty;

            if (t1.Expired)
            {
                txtExpired.ForeColor = System.Drawing.Color.Red;
                txtExpired.Text = "Expired";
            }
            else
            {
                txtExpired.ForeColor = System.Drawing.Color.Green;
                txtExpired.Text = "Active";
            }

            txtSc.Text = t1.ServiceCode ?? string.Empty;
            ServiceCodeInfo? sc = t1.ServiceCode != null ? ServiceCodeParser.Parse(t1.ServiceCode) : null;
            if (sc != null)
            {
                txtSc1.Text = sc.Meaning1;
                txtSc2.Text = sc.Meaning2;
                txtSc3.Text = sc.Meaning3;
            }

            txtDd.Text = t1.DiscretionaryData ?? string.Empty;

            txtEtx.Text = t1.EndSentinel.ToString();

            txtLrc.Text = LrcCalculator.CalculateAsciiLrc(parser.Track1Raw ?? string.Empty).ToString("X2");
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (bytes == null || bytes.Length < 1)
            {
                MessageBox.Show("Nothing to save.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using SaveFileDialog dialog = new()
            {
                Title = "Save Magnetic Stip Card Data",
                InitialDirectory = @"%userprofile%\Documents",
                Filter = "Binary file (*.bin)|*.bin",
                DefaultExt = "bin",
                AddExtension = true,
                FileName = $"swipe_{DateTime.Now:yyyyMMdd_HHmmss}"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                if (Path.GetExtension(dialog.FileName).Equals(".bin", StringComparison.OrdinalIgnoreCase))
                {
                    File.WriteAllBytes(dialog.FileName, bytes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new()
            {
                Title = "Open Magnetic Stip Card Data",
                InitialDirectory = @"%userprofile%\Documents",
                Filter = "Binary file (*.bin)|*.bin",
                DefaultExt = "bin",
                Multiselect = false
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                byte[] data = File.ReadAllBytes(dialog.FileName);
                _buffer.Append(Encoding.ASCII.GetString(data));
                this.bytes = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ProcessSwipe(_buffer.ToString());
            _buffer.Clear();
        }
    }
}
