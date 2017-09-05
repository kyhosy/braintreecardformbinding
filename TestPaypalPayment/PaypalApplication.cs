using System;
using Android.App;
using Com.Facebook.Stetho;
using Square.LeakCanary;
namespace TestPaypalPayment
{
	[Application(Theme = "@style/AppTheme")]
	public class PaypalApplication : Application
	{
		public PaypalApplication(IntPtr handle, global::Android.Runtime.JniHandleOwnership transer) : base(handle, transer)
		{
		}

		public override void OnCreate()
		{
			base.OnCreate();
			LeakCanaryXamarin.Install(this);
			Stetho.InitializeWithDefaults(this);
		}
	}
}
