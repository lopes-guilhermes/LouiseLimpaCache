namespace LouiseLimpaCache
{
    public static class LimparCacheIE
    {
        public static bool Limpar()
        {
            //Temporary Internet Files
            var tempInternetFiles = System.Diagnostics.Process
                .Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8")
                .WaitForExit(1000 * 10); ;

            //Cookies
            var cookies = System.Diagnostics.Process
                .Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 2")
                .WaitForExit(1000 * 10);

            return tempInternetFiles && cookies;

            //History
            //System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 1");

            //Form(Data)
            //System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 16");

            //Passwords
            //System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 32");

            //Delete(All)
            //System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 255");

            //Delete All – Also delete files and settings stored by add-ons 
            //System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 4351");
        }
    }
}
