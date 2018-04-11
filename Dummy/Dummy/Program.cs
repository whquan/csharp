using System;

namespace Dummy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

//# decouple
//    - 解析 csv

//    - 每个表，定义一个 Object，表示一行
//        序列化的时候，转成 key => value 的形式
//        - key: 先用string/bytes 
//        - value: json string
//    - payload: json string
//        json encode, json decode
//        https://blog.csdn.net/sayesan/article/details/78496324
//    使用c#对数据的存取redis

//    - 写 New-Order
//    - 写 Payment



//# c# 对接 redis，往里面存入数据
//    ServiceStack redis client
//# 



//using (var textReader = new StreamReader("filepath")) 
//{
//    var line = textReader.ReadLine();
//var arr = line.Split(',');
//    if (arr.Length != 3) {
//        // pass
//    } else {

//    }
   
//}

//            int entriesFound = 0;
//            using (var textReader = new StreamReader("fileName"))
//            {
//                string line = textReader.ReadLine();
//int skipCount = 0;
//                while (line != null && skipCount< 1)
//                {
//                    line = textReader.ReadLine();
                    
//                    skipCount++;
//                }

//                while (line != null)
//                {
//                    string[] columns = line.Split(_Delimiter);
////perform your logic
//entriesFound++;
//                    line = textReader.ReadLine();
//                }
//            }


//# object to json
//    https://blog.csdn.net/sayesan/article/details/78496324
//# object 
    //https://www.cnblogs.com/GreenLeaves/p/7479412.html
    //每个数据行，组成 Object，然后使用 Object 的属性访问
    //数据行的 Object, getKey, getValue
    //假定key 和 value 都是string，直接存入 redis



