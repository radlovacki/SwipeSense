using System.Text;

namespace SwipeSense
{
    public partial class SwipeSenseForm : Form
    {
        private readonly StringBuilder _buffer = new();
        byte[] bytes;
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
            txtTracks.Text = buffer;
            var parser = new Parser(buffer);
            txtTrack1.Text = parser.Track1 ?? string.Empty;
            txtTrack2.Text = parser.Track2 ?? string.Empty;
            txtTrack3.Text = parser.Track3 ?? string.Empty;
            txtFormatCode.Text = parser.FormatCode.ToString();
            txtFormatCodeDescription.Text = parser.FormatDescription;
            string pan = parser.PrimaryAccountNumber ?? string.Empty;
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
            txtPrimaryAccountNumberValidated.Text = parser.LuhnValid ? "Valid" : "Invalid";


            var repo = new CardPatternRepository("CardPatterns.json");
            if (repo.IsValidPAN(pan))
            {
                txtCard.Text = repo.FindByPAN(pan)?.Name ?? "Unknown";
                txtRegion.Text = repo.FindByPAN(pan)?.Region ?? "Unknown";
                txtType.Text = (repo.FindByPAN(pan)?.Type != null && repo.FindByPAN(pan)!.Type.Count > 0)
                    ? string.Join(", ", repo.FindByPAN(pan)!.Type)
                    : "Unknown";
                txtCVV.Text = (repo.FindByPAN(pan)?.CVVLength != null)
                    ? string.Join(", ", repo.FindByPAN(pan)!.CVVLength)
                    : "Unknown";
                txtIso.Text = (repo.FindByPAN(pan)?.ISOStandards != null)
                    ? string.Join(", ", repo.FindByPAN(pan)!.ISOStandards)
                    : "Unknown";
                txtLrc.Text = LrcCalc.CalculateAsciiLrc("Calculated ASCII: " + parser.Track1 ?? string.Empty).ToString("X2");
                txtDate.Text = (string.Concat(parser.ExpirationDate.AsSpan(2, 2), "/", parser.ExpirationDate.AsSpan(0, 2))) ?? string.Empty;
                txtExpired.Text = parser.Expired ? "Yes" : "No";
                txtSc.Text = parser.ServiceCode ?? string.Empty;
                ServiceCodeInfo? sc = parser.ServiceCode != null
                    ? ServiceCodeParser.Parse(parser.ServiceCode)
                    : null;
                if (sc != null)
                {
                    txtSc1.Text = sc.Meaning1;
                    txtSc2.Text = sc.Meaning2;
                    txtSc3.Text = sc.Meaning3;
                }
                txtDd.Text = parser.DiscretionaryData ?? string.Empty;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (bytes.Length < 1)
            {
                MessageBox.Show("Nothing to save.", "Save",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using SaveFileDialog dlg = new SaveFileDialog
            {
                Title = "Save swipe data",
                Filter = "Binary file (*.bin)|*.bin|Text file (*.txt)|*.txt",
                DefaultExt = "bin",
                AddExtension = true,
                FileName = "swipe"
            };

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                if (Path.GetExtension(dlg.FileName).Equals(".bin", StringComparison.OrdinalIgnoreCase))
                {
                    SaveAsBinary(dlg.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveAsBinary(string fileName)
        {
            File.WriteAllBytes(fileName, this.bytes);
        }

    }
}
