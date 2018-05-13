namespace MVVMCalc.ViewModel
{
    using System;
    using System.Collections.Generic;
    using MVVMCalc.Common;
    using MVVMCalc.Model;

    /// <summary>
    /// CalculateType構造体表示用ViewModel
    /// </summary>
    /// 
    /*
     MVVMパターンでViewModelを実装する場合、INotifyPropertyChanged インターフェースを実装するのが面倒という理由もあって、
     INotifyPropertyChanged インターフェースを実装した抽象クラス「 ViewModelBase 」を用意したりすることが、
     世の中的に割と定番となっている
     ViewModel は INotifyPropertyChanged インターフェイスを実装したもの
     */
    /*
       まず、計算方法を表すCalculateType列挙子を表すためのViewModelクラスを作成します。
       このViewModelクラスは、CalculateTypeの値と選択項目に表示する文字列の対応づけを行います。
       ここでは内部的にCalculateTypeとstringの対応をDictionaryで管理してEnumのメソッドを使用して
       CalculateTypeの値を全て取得してCalculateTypeViewModelを作成するヘルパーメソッドも作成しています。
     */
    public class CalculateTypeViewModel : ViewModelBase
    {
        /// <summary>
        /// 計算方法
        /// </summary>
        public CalculateType CalculateType { get; private set; }

        /// <summary>
        /// 表示名
        /// </summary>
        public string Label { get; private set; }

        /// <summary>
        /// 計算方法と表示名を設定してインスタンスを生成します。
        /// </summary>
        /// <param name="calculateType">計算方法</param>
        /// <param name="label">表示名</param>
        public CalculateTypeViewModel(CalculateType calculateType, string label)
        {
            this.CalculateType = calculateType;
            this.Label = label;
        }

        /// <summary>
        /// CalculateTypeの値と表示用ラベルのマップ
        /// </summary>
        private static Dictionary<CalculateType, string> typeLabelMap = new Dictionary<CalculateType, string>
        {
            { CalculateType.None, "未選択" },
            { CalculateType.Add, "足し算" },
            { CalculateType.Sub, "引き算" },
            { CalculateType.Mul, "掛け算" },
            { CalculateType.Div, "割り算" }
        };

        /// <summary>
        /// 計算方法からラベル名を自動的に引き当ててCalculateTypeViewModelのインスタンスを生成する。
        /// </summary>
        /// <param name="type">計算方法</param>
        /// <returns>生成されたインスタンス</returns>
        public static CalculateTypeViewModel Create(CalculateType type)
        {
            return new CalculateTypeViewModel(type, typeLabelMap[type]);
        }

        /// <summary>
        /// CalculateTypeの全値に対応するCalculateTypeViewModelを作成する。
        /// </summary>
        /// <returns>生成されたインスタンス</returns>
        public static IEnumerable<CalculateTypeViewModel> Create()
        {
            foreach (CalculateType e in Enum.GetValues(typeof(CalculateType)))
            {
                yield return Create(e);
            }
        }
    }
}
