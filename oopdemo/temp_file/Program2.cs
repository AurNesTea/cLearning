// using oop.demo;

// internal class Program
// {
//     public delegate void Score();
//     public static int TotalScore = 0;
//     private static void Main(string[] args)
//     {
//         #region Enum
//         // Enum.GetValues 方法
//         // 在指定的列舉中擷取常數值的陣列。
//         Console.WriteLine("在指定的列舉中擷取常數值的陣列。");
//         Console.WriteLine("顏色枚舉類型所有元素為:");
//         foreach (int s in Enum.GetValues(typeof(enColors)))
//         {
//             Console.WriteLine(s);
//         }
//         Console.WriteLine();

//         Console.WriteLine("樣式枚舉類型所有元素為:");
//         foreach (int s in Enum.GetValues(typeof(enPetType)))
//         {
//             Console.WriteLine(s);
//         }
//         Console.WriteLine();

//         // Enum.GetNames 方法
//         // 在指定的列舉中擷取常數名稱的陣列。
//         Console.WriteLine("在指定的列舉中擷取常數名稱的陣列。");
//         Console.WriteLine("顏色枚舉類型所有元素為:");
//         foreach (string s in Enum.GetNames(typeof(enColors)))
//         {
//             Console.WriteLine(s);
//         }
//         Console.WriteLine();

//         Console.WriteLine("樣式枚舉類型所有元素為:");
//         foreach (string s in Enum.GetNames(typeof(enStyles)))
//         {
//             Console.WriteLine(s);
//         }
//         Console.WriteLine();

//         // Enum.IsDefined 方法
//         // 如果在 enumType 中的常數有等於 value 的數值，則為 true，否則為 false。
//         Object value = new object();

//         // 使用成員的基礎整數值調用 IsDefined.
//         Console.WriteLine("以下判斷結果以 enPetType 枚舉類型來當範例:");
//         value = 1;
//         Console.WriteLine("值 = {0} 時是否有定義 = {1}", value, Enum.IsDefined(typeof(enPetType), value));
//         // 使用無效的基礎整數值調用 IsDefined.
//         value = 64;
//         Console.WriteLine("值 = {0} 時是否有定義 = {1}", value, Enum.IsDefined(typeof(enPetType), value));
//         // 使用包含成員名稱的字符串調用 IsDefined.
//         value = "Rodent";
//         Console.WriteLine("值 = {0} 時是否有定義 = {1}", value, Enum.IsDefined(typeof(enPetType), value));
//         // 使用 enPetType 類型的變量調用 IsDefined.
//         value = enPetType.Dog;
//         Console.WriteLine("值 = {0} 時是否有定義 = {1}", value, Enum.IsDefined(typeof(enPetType), value));
//         value = enPetType.Dog | enPetType.Cat;
//         Console.WriteLine("值 = {0} 時是否有定義 = {1}", value, Enum.IsDefined(typeof(enPetType), value));
//         // 使用大寫成員名稱調用 IsDefined.
//         value = "None";
//         Console.WriteLine("值 = {0} 時是否有定義 = {1}", value, Enum.IsDefined(typeof(enPetType), value));
//         value = "NONE";
//         Console.WriteLine("值 = {0} 時是否有定義 = {1}", value, Enum.IsDefined(typeof(enPetType), value));
//         // 使用組合值調用 IsDefined
//         value = enPetType.Dog | enPetType.Bird;
//         Console.WriteLine("值 = {0:D} : 是否有定義 = {1}", value, Enum.IsDefined(typeof(enPetType), value));
//         Console.WriteLine();

//         // Enum.ToString 方法
//         Console.WriteLine("將這個執行個體的值轉換為它的相等字串表示。");
//         Enum myColors = enColors.Red;
//         Console.WriteLine("這個實例的值是 '{0}'", myColors.ToString());
//         #endregion

//         #region Value / Reference
//         // 傳值 (Call By Value) / 傳址 (Call By Reference)
//         Console.WriteLine("傳值 (Call By Value) / 傳址 (Call By Reference):");
//         A();
//         #endregion

//         #region 繼承
//         // 繼承範例程式
//         Console.WriteLine("繼承範例程式:");
//         Lite Vino50 = new Lite();
//         Vino50.BrandName = "YAMAHA";
//         Vino50.ModelName = "VINO";
//         Vino50.CC = 50;
//         Vino50.Color = enColors.Red;
//         Vino50.OilType = enOilType.Type95;
//         Console.WriteLine(Vino50.BaseInfo);

//         // 測試事件及方法
//         Car car = new Car();
//         car.SetCarData(50, 20, 30);
//         int int_volume = car.GetCarValume();
//         Console.WriteLine("車子的體積 = 長度 x 寛度 x 高度");
//         Console.WriteLine($"= {car.Length} x {car.Width} x {car.Height}");
//         Console.WriteLine($"= {int_volume}");
//         #endregion

//         #region 解構子
//         // 使用解構子的各種範例
//         //範例一
//         Console.WriteLine("使用解構子, 範例一:");
//         Lite YamahaYY50 = new Lite();
//         YamahaYY50.BrandName = "YAMAHA";
//         YamahaYY50.ModelName = "YY60";
//         YamahaYY50.Color = enColors.Red;
//         Console.WriteLine($"YamahaYY50: {YamahaYY50.BrandName}, {YamahaYY50.ModelName}, {YamahaYY50.Color}");

//         //範例二
//         Console.WriteLine("使用解構子, 範例二");
//         using (Lite YamahaYY60 = new Lite())
//         {
//             using (Lite YamahaYY61 = new Lite())
//             {
//                 YamahaYY60.BrandName = "YAMAHA";
//                 YamahaYY60.ModelName = "YY60";
//                 YamahaYY60.Color = enColors.Red;
//                 Console.WriteLine($"YamahaYY60: {YamahaYY60.BrandName} {YamahaYY60.ModelName} {YamahaYY60.Color}");

//                 YamahaYY61.BrandName = "YAMAHA";
//                 YamahaYY61.ModelName = "YY61";
//                 YamahaYY61.Color = enColors.Red;
//                 Console.WriteLine($"YamahaYY61: {YamahaYY60.BrandName} {YamahaYY60.ModelName} {YamahaYY60.Color}");
//             }
//         }
//         //範例三
//         Console.WriteLine("使用解構子, 範例三");
//         using (Lite YamahaYY70 = new Lite())
//         using (Lite YamahaYY71 = new Lite())
//         {
//             YamahaYY70.BrandName = "YAMAHA";
//             YamahaYY70.ModelName = "YY70";
//             YamahaYY70.Color = enColors.Red;
//             Console.WriteLine($"YamahaYY70: {YamahaYY70.BrandName} {YamahaYY70.ModelName} {YamahaYY70.Color}");

//             YamahaYY71.BrandName = "YAMAHA";
//             YamahaYY71.ModelName = "YY71";
//             YamahaYY71.Color = enColors.Red;
//             Console.WriteLine($"YamahaYY71: {YamahaYY71.BrandName} {YamahaYY71.ModelName} {YamahaYY71.Color}");
//         }

//         //範例四
//         Console.WriteLine("使用解構子, 範例四");
//         using var YamahaYY91 = new Lite();
//         using var YamahaYY92 = new Lite();
//         YamahaYY91.Color = enColors.Blue;
//         YamahaYY91.BrandName = "Yamaha";
//         YamahaYY91.ModelName = "YY91";
//         YamahaYY92.Color = enColors.Red;
//         YamahaYY92.BrandName = "Yamaha";
//         YamahaYY92.ModelName = "YY92";
//         Console.WriteLine($"YamahaYY91: {YamahaYY91.BrandName}, {YamahaYY91.ModelName}, {YamahaYY91.Color}");
//         Console.WriteLine($"YamahaYY92: {YamahaYY92.BrandName}, {YamahaYY92.ModelName}, {YamahaYY92.Color}");
//         #endregion

//         #region 建構子
//         // 實作化類別使用建構子範例
//         // 不使用 using
//         Console.WriteLine("不使用 using");
//         Lite YamahaYY31 = new Lite();
//         YamahaYY31.BrandName = "Yamaha";
//         YamahaYY31.ModelName = "YY61";
//         YamahaYY31.Color = enColors.Blue;
//         YamahaYY31.CC = 125;
//         YamahaYY31.OilType = enOilType.Type98;
//         Console.WriteLine(YamahaYY31.BaseInfo);

//         Lite YamahaYY32 = new Lite("Yamaha", "YY32", enColors.Red);
//         YamahaYY32.CC = 150;
//         YamahaYY32.OilType = enOilType.Type95;
//         Console.WriteLine(YamahaYY32.BaseInfo);

//         Console.WriteLine();
//         Console.WriteLine("使用 using");
//         using (Lite YamahaYY61 = new Lite())
//         {
//             YamahaYY61.BrandName = "YAMAHA";
//             YamahaYY61.ModelName = "YY61";
//             YamahaYY61.Color = enColors.Blue;
//             YamahaYY61.CC = 125;
//             YamahaYY61.OilType = enOilType.Type98;
//             Console.WriteLine(YamahaYY61.BaseInfo);
//         }

//         using (Lite YamahaYY62 = new Lite("YAMAHA", "YY62", enColors.Red))
//         {
//             YamahaYY62.CC = 125;
//             YamahaYY62.OilType = enOilType.Type95;
//             Console.WriteLine(YamahaYY62.BaseInfo);
//         }
//         #endregion

//         #region 多載
//         // 方法多載
//         Console.WriteLine("方法多載");
//         using (ClassAdd classAdd = new ClassAdd())
//         {
//             int int_value1 = classAdd.Add(4);
//             int int_value2 = classAdd.Add(1, 2);
//             double dbl_value = classAdd.Add(0.5d, 0.3d);
//             Console.WriteLine($"整數自我相加 4 + 4 = {int_value1}");
//             Console.WriteLine($"整數相加 1 + 2 = {int_value2}");
//             Console.WriteLine($"小數相加 0.5 + 0.3 = {dbl_value}");
//         }

//         // 建構子多載
//         Console.WriteLine("建構子多載:");
//         using var car1 = new Car();
//         using var car2 = new Car("BMW", "X5");
//         Console.WriteLine($"car1 = {car1.BrandName}, {car1.ModelName}, {car1.Color}");
//         Console.WriteLine($"car2 = {car.BrandName}, {car2.ModelName}, {car2.Color}");
//         #endregion

//         #region 部分類別(Partial Class)
//         Console.WriteLine("Partial Class Example:");
//         string str_msg = "";
//         using (var storyBook = new Storybook())
//         {
//             storyBook.BookNo = "A0001";
//             storyBook.BookName = "我的故事書";
//             storyBook.PulisherName = "光明出版社";
//             storyBook.BookPrice = 500;

//             str_msg += $"書號:{storyBook.BookNo} ";
//             str_msg += $"書名:{storyBook.BookName} ";
//             Console.WriteLine(str_msg);
//             str_msg += $"出版社:{storyBook.BookNo} ";
//             str_msg += $"售價:{storyBook.BookPrice}";
//             Console.WriteLine(str_msg);
//         }
//         #endregion

//         #region 多型(Polymorphism)
//         using var person = new Person();
//         using var daming = new Daming();
//         using var xiaohua = new Xiaohua();
//         Console.WriteLine(person.PersonInfo());
//         Console.WriteLine(daming.PersonInfo());
//         Console.WriteLine(xiaohua.PersonInfo());
//         #endregion

//         #region 靜態(Static)
//         // Static Class
//         Console.WriteLine("靜態(Static): Static Class");
//         UserService.UserNo = "001";
//         UserService.UserName = "Damin Wang";
//         UserService.Login();
//         Console.WriteLine(UserService.LoginInfo);

//         UserService.Login("002", "Xaiohua");
//         Console.WriteLine(UserService.LoginInfo);

//         UserService.Logout();
//         Console.WriteLine(UserService.LoginInfo);

//         // 類別設定成不是靜態,屬性設定成靜態
//         Console.WriteLine("靜態(Static): 類別設定成不是靜態,屬性設定成靜態");
//         UserService2.UserNo = "010";
//         UserService2.UserName = "Daming Wang";
//         using var user = new UserService2();
//         //登入
//         user.Login();
//         Console.WriteLine(UserService2.LoginInfo);
//         //登入
//         user.Login("002", "Xiaohua Lee");
//         Console.WriteLine(UserService2.LoginInfo);
//         //登出
//         user.Logout();
//         Console.WriteLine(UserService2.LoginInfo);
//         #endregion

//         #region Interface
//         Console.WriteLine();
//         Console.WriteLine("Interface example");
//         using var fruit = new FruitCarton();
//         fruit.Package();
//         Console.WriteLine(fruit.CartonInfo);
//         #endregion

//         #region 泛型 Generics
//         Console.WriteLine();
//         Console.WriteLine("泛型 Generics example");
//         //數字
//         Console.WriteLine("----------------數字---------------");
//         GenericDemo<int> intValue = new GenericDemo<int>();
//         intValue.AddItem(3); intValue.AddItem(4); intValue.AddItem(5); intValue.AddItem(2);
//         int index = 0;
//         foreach (var item in intValue.DataList)
//         {
//             index++;
//             Console.WriteLine($"第 {index}  個元素值 = {item}");
//         }

//         //文字
//         Console.WriteLine();
//         Console.WriteLine("----------------文字---------------");
//         GenericDemo<string> strValue = new GenericDemo<string>();
//         strValue.AddItem("王小明"); strValue.AddItem("陳小月"); strValue.AddItem("楊小國"); strValue.AddItem("李小天");
//         var index2 = 0;
//         foreach (var item in strValue.DataList)
//         {
//             index2++;
//             Console.WriteLine($"第 {index2} 個元素值 = {item}");
//         }

//         //模型類別
//         Console.WriteLine();
//         Console.WriteLine("----------------模型類別---------------");
//         GenericDemo<Users> users = new GenericDemo<Users>();
//         users.AddItem(new Users() { UserNo = "001", UserName = "王大明", Age = 20 });
//         users.AddItem(new Users() { UserNo = "002", UserName = "王小明", Age = 20 });
//         users.AddItem(new Users() { UserNo = "003", UserName = "王大華", Age = 20 });
//         var index3 = 0;
//         foreach (var item in users.DataList)
//         {
//             index3++;
//             Console.WriteLine($"{index3}. UserNo={item.UserNo}, UserName={item.UserName}, UserAge={item.Age}");
//         }
//         #endregion

//         #region 委派 Delegate
//         Console.WriteLine();
//         Console.WriteLine("委派 Delegate example");
//         //數字
//         using var demo = new DelegateDemo();
//         demo.Run();
//         #endregion

//         Console.WriteLine("按任意鍵結束 ...");
//         Console.ReadKey();
//     }

//     public static void A()
//     {
//         int X = 0;
//         int W = B(X);
//         Console.WriteLine($"X = {X}, W = {W}");
//     }

//     public static int B(int Y)
//     {
//         Y += 100;
//         return Y;
//     }
// }