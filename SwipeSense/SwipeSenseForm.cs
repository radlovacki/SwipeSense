using System.Text;

namespace SwipeSense
{
    public partial class SwipeSenseForm : Form
    {
        private readonly StringBuilder _buffer = new();
        public SwipeSenseForm()
        {
            InitializeComponent();
        }

        private void SwipeSenseForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ProcessSwipe(_buffer.ToString());
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
        }
    }
}
