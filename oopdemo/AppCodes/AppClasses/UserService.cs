/// <summary>
/// 管理登入使用者的服務類別
/// </summary>
public static class UserService
{
    /// <summary>
    /// 是否已經登入系統變數
    /// </summary>
    private static bool _IsLogin = false;
    /// <summary>
    /// 是否已經登入系統屬性
    /// </summary>
    public static bool IsLogin { get { return _IsLogin; } }
    /// <summary>
    /// 登入使用者帳號
    /// </summary>
    public static string UserNo { get; set; } = "";
    /// <summary>
    /// 登入使用者姓名
    /// </summary>
    public static string UserName { get; set; } = "";
    /// <summary>
    /// 顯示目前登入資訊
    /// </summary>
    public static string LoginInfo
    {
        get
        {
            if (_IsLogin) return $"User: {UserNo}, {UserName}";
            return "Not Login";
        }
    }
    /// <summary>
    /// 使用者登入事件,需事先指定使用者帳號及姓名
    /// </summary>
    public static void Login()
    {
        _IsLogin = true;
    }
    /// <summary>
    /// 使用者登入事件
    /// </summary>
    /// <param name="userNo">使用者帳號</param>
    /// <param name="userName">使用者姓名</param>
    public static void Login(string userNo, string userName)
    {
        _IsLogin = true;
        UserNo = userNo;
        UserName = userName;
    }
    /// <summary>
    /// 使用者登出事件
    /// </summary>
    public static void Logout()
    {
        _IsLogin = false;
        UserNo = "None";
        UserName = "Guest";
    }
}


// 類別設定成不是靜態,屬性設定成靜態
public class UserService2 : BaseClass
{
    private static bool _IsLogin = false;

    public static bool IsLogin { get { return _IsLogin; } }

    public static string UserNo { get; set; } = "";
    public static string UserName { get; set; } = "";

    public static string LoginInfo
    {
        get
        {
            if (_IsLogin) return $"User: {UserNo}, {UserName}";
            return $"Not Login";
        }
    }

    public void Login()
    {
        _IsLogin = true;
    }
    public void Login(string userNo, string userName)
    {
        _IsLogin = true;
        UserNo = userNo;
        UserName = userName;
    }
    public void Logout()
    {
        _IsLogin = false;
        UserNo = "None";
        UserName = "Guest";
    }
}