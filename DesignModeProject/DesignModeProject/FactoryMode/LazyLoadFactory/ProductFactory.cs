using System.Collections.Generic;

namespace DesignModeProject.FactoryMode.LazyLoadFactory
{
    /// <summary>
    /// 使用工厂进行延时加载
    /// 不符合开闭模式
    /// </summary>
    public class ProductFactory
    {
        public static Dictionary<string,Product> dic=new Dictionary<string, Product>();

        public static Product CreateProduct(string type)
        {
            Product product = null;
            if (dic.ContainsKey(type))
            {
                product = dic[type];
            }
            else
            {
                if (type=="1")
                {
                    product=new Product1();
                }
                else
                {
                    product=new Product2();
                }
                dic.Add(type,product);
            }
            return product;
        }
    }
}