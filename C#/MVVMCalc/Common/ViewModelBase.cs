namespace MVVMCalc.Common
{
    using System.ComponentModel;

    /// <summary>
    /// ViewModelの基本クラス。INotifyPropertyChangedの実装を提供します。
    /// </summary>
    /// 
    //The INotifyPropertyChanged 
    //interface is used to notify clients, typically binding clients, that a property value has changed.
    //
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// プロパティの変更があったときに発行されます。
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /*

                   //
                   // 概要:
                   //     処理するメソッドを表す、 System.ComponentModel.INotifyPropertyChanged.PropertyChanged コンポーネントで、プロパティが変更されたときに発生するイベントです。
                   //
                   // パラメーター:
                   //   sender:
                   //     イベントのソース。
                   //
                   //   e:
                   //     イベント データを格納している System.ComponentModel.PropertyChangedEventArgs。
                   // public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);
                */
        //When you create a PropertyChangedEventHandler delegate, you identify the method that will handle the event.
        //


        /// <summary>
        /// PropertyChangedイベントを発行します。
        /// </summary>
        /// <param name="propertyName">プロパティ名</param>
        protected virtual void RaisePropertyChanged(string propertyName)//PropertyChangedを発行するためのメソッド
        {
            var h = this.PropertyChanged;
            if (h != null)
            {
                h(this, new PropertyChangedEventArgs(propertyName));
                //	PropertyChangedEventArgs(String)  Initializes a new instance of the PropertyChangedEventArgs class.	
                /*


                   using System.Runtime;

                   namespace System.ComponentModel
                   {         
                 //
                 // 概要:
                 //     System.ComponentModel.INotifyPropertyChanged.PropertyChanged イベントのデータを提供します。
                   public class PropertyChangedEventArgs : EventArgs
                   {
                 //
                 // 概要:
                 //     System.ComponentModel.PropertyChangedEventArgs クラスの新しいインスタンスを初期化します。
                 //
                 // パラメーター:
                 //   propertyName:
                 //     変更されたプロパティの名前。
                   [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
                    public PropertyChangedEventArgs(string propertyName);

                 //
                 // 概要:
                 //     変更されたプロパティの名前を取得します。
                 //
                 // 戻り値:
                 //     変更されたプロパティの名前。
                    public virtual string PropertyName { get; }
                     }
                     }
                 */
            }
        }
    }
}