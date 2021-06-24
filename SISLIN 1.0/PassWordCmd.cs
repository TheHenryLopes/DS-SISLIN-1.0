using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;

namespace SISLIN_1._0
{
    public class PassWordCmd : ICommand
    {
        public string Password { get; set; }

        #region Icommand Member

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute (object parameter)
        {
            PasswordBox boxPass = (PasswordBox)parameter;
            Password = boxPass.Password;

            if (Password == "12345")
            {
                MenuPrincipal Chamar = new MenuPrincipal();
                Chamar.ShowDialog();
            }
            else
            {
                System.Windows.MessageBox.Show("Senha Incorreta!");
            }
        }
        #endregion
    }
}
