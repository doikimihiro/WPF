namespace WpfApplication.Commands
{
    using System;
    using System.Windows;
    using System.Windows.Input;

    public class OpenMessageDialogCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        
        public bool CanExecute(object parameter)
        {
            return true;
        }
        
        public void Execute(object parameter)
        {
            var name = parameter as string;

            var message = "こんにちは、" + name + "さん";

            MessageBox.Show(message);
        }
        
    }
}
//MVVMではViewModel
//OpenMessageDialogCommandはICommandを継承しているから、buttonのCommandプロパティに入れられる
//ICommandはInterface
//Interfaceは継承される前提で、定められたメソッドをサブクラスで実装する
//CanExecuteChangedとCanExecuteとExcuteを定義しなければ、ICommandを継承することはできない
