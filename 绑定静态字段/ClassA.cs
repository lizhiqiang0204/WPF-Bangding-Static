using System;
using System.ComponentModel;

namespace 绑定静态字段
{
    public class ClassA
    {
        private static string label = "新建类A的标签";
        public static string myLabel
        {
            get { return label; }
            set
            {
                label = value;
                StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(nameof(myLabel)));//异步更新myLabel属性
            }
        }
        public static event EventHandler<PropertyChangedEventArgs> StaticPropertyChanged;//静态事件处理属性更改
    }
}
