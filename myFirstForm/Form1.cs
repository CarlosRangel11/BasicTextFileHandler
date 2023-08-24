namespace myFirstForm {
    public partial class Form1 : Form {
        private FileService.IService1 proxy = new FileService.Service1Client();
        private int YPosition = 450;
        public Form1() {
            InitializeComponent();
        }

        private void saveInput_Click(object sender, EventArgs e) {
            proxy.PutStringToFile(FileNameInput.Text, stringInput.Text);

            Label output = new Label();
            output.Text = $"File {FileNameInput.Text} has text: {proxy.GetStringFromFile(FileNameInput.Text)}";

            output.Location = new Point(128, YPosition);  // same x as rest of form, y below button (by 100)
            output.AutoSize = true;                 //autofits label to fit text

            this.Controls.Add(output);
            YPosition += 50;
        }
    }
}