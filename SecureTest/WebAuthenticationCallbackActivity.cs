using Android.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTest
{
    [Activity(NoHistory = true, Exported = true, LaunchMode = Android.Content.PM.LaunchMode.SingleTop)]
    [IntentFilter(new[] { Android.Content.Intent.ActionView },
       Categories = new[] { Android.Content.Intent.CategoryDefault, Android.Content.Intent.CategoryBrowsable },
       DataScheme = "trimapp")]
    public class WebAuthenticationCallbackActivity : WebAuthenticatorCallbackActivity
    {
    }
}
