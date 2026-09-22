
namespace TuNominaYa.Methods_Funcs
{
    public static class Funcs
    {
        public static void Adopt(Form? dad, Form? son)
        {
            if (dad == null || son == null) return;

            dad.AddOwnedForm(son);
            son.StartPosition = FormStartPosition.CenterScreen;
            son.Location = dad.Location;

            son.Show();
        }

        public static void AdoptDialog(Form? dad, Form? son)
        {
            if (dad == null || son == null) return;

            dad.AddOwnedForm(son);
            son.StartPosition = FormStartPosition.Manual;
            son.Location = dad.Location;

            son.ShowDialog();
        }
    }
}
