using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.Internals
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface IPlatformServices
	{
		bool IsInvokeRequired { get; }

		void BeginInvokeOnMainThread(Action action);

		Ticker CreateTicker();

		Assembly[] GetAssemblies();

		string GetHash(string input);

		[Obsolete("GetMD5Hash is obsolete as of version 4.7.0")]
		string GetMD5Hash(string input);

		double GetNamedSize(NamedSize size, Type targetElementType, bool useOldSizes);

		Task<Stream> GetStreamAsync(Uri uri, CancellationToken cancellationToken);

		IIsolatedStorageFile GetUserStoreForApplication();

		void OpenUriAction(Uri uri);

		void StartTimer(TimeSpan interval, Func<bool> callback);

		string RuntimePlatform { get; }

		void QuitApplication();

		SizeRequest GetNativeSize(VisualElement view, double widthConstraint, double heightConstraint);
	}
}