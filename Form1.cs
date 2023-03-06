using System.Windows.Forms;

namespace DemoHelpSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Crea una nova instància del control HelpProvider
            //HelpProvider helpProvider1 = new HelpProvider();
            //(Afegir Control HelProvider al Form1)

            //Per mostrar el botó d'ajuda contextual cal assignar a aquestes propietats:
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Defineix el fitxer d'ajuda, cal definir la ruta relativa o absoluta
            //helpProvider1.HelpNamespace = "MyApp.htm";
            //helpProvider1.HelpNamespace = "MyApp.chm";
            

            // Associar el control HelpProvider amb cada control que té ajuda contextual
            helpProvider1.SetHelpString(this.button1, "Aquest botó serveix per desar les dades");
            helpProvider1.SetHelpString(this.textBox1, "Introduïu el vostre nom aquí");

        }
    }
}