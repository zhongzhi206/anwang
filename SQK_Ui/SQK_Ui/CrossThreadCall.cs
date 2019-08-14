/*---------------------------------------------
整理自用 C# WinForm 常用Ui组件
适用版本：.Net 4.6 (32、64位)
设计：Song Qiao Ke
          Email: Qiaoke_Song@163.com
          QQ：2452243110
最后更新：2018.2.23
-----------------------------------------------*/


using System.Threading;
using System.Windows.Forms;

public static class CrossThreadCall
{
    public static void CrossThreadCalls(this Control ctl, ThreadStart del)
    {
        if (del == null) return;
        if (ctl.InvokeRequired)
            ctl.Invoke(del, null);
        else
            del();
    }
}
