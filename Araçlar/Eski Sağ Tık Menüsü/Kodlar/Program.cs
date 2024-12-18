using System.Diagnostics;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Copyright (c) 2024,Elektronikçi Kedi");
Console.WriteLine("Windows 11 Eski Sağ Tık Menüsü / Windows 11 Legacy Right Click Menu");
int i = 0;
do
{
    Console.WriteLine("Please Select Language / Lütfen Dil Seçin");
    Console.WriteLine("1)Türkçe");
    Console.WriteLine("2)English");
    Console.Write("1-2 : ");
    string a = Console.ReadLine();
    if (a != null)
    {
        if (a == "1")
        {
            Console.WriteLine("Ne Yapmak İstiyorsunuz ?");
            Console.WriteLine("1)Windows 10 Sağ Tık Menüsü Yap");
            Console.WriteLine("2)Windows 11 Sağ Tık Menüsü Yap");
            string b = Console.ReadLine();
            if (b != null)
            {
                if (b == "1")
                {
                    Console.WriteLine("İşleminiz Tamamlanıyor.. Lütfen Bekleyiniz.");
                    Process.Start("cmd.exe", "/k reg add HKCU\\Software\\Classes\\CLSID\\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\\InprocServer32 /ve /d \"\" /f");
                    i++;
                    /*Console.WriteLine("Uygulamadan Çıkmak İçin Bir Tuşa Basın...");
                    Console.ReadKey();
                    return;*/
                    foreach (var process in Process.GetProcessesByName("explorer"))
                    {
                        try
                        {
                            process.Kill();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Explorer'ı sonlandırırken hata oluştu: {ex.Message}");
                        }
                    }

                    // Explorer'ı yeniden başlat
                    try
                    {
                        Process.Start("explorer.exe");
                        Console.WriteLine("Windows Explorer yeniden başlatıldı.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Explorer'ı başlatırken hata oluştu: {ex.Message}");
                    }
                }
                else if(b=="2")
                {
                    Console.WriteLine("İşleminiz Tamamlanıyor.. Lütfen Bekleyiniz.");
                    Process.Start("cmd.exe", "/k reg delete HKCU\\SOFTWARE\\Classes\\CLSID\\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2} /f");
                    i++;
                    /*Console.WriteLine("Uygulamadan Çıkmak İçin Bir Tuşa Basın...");
                    Console.ReadKey();
                    return;*/
                    foreach (var process in Process.GetProcessesByName("explorer"))
                    {
                        try
                        {
                            process.Kill();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Explorer'ı sonlandırırken hata oluştu: {ex.Message}");
                        }
                    }

                    // Explorer'ı yeniden başlat
                    try
                    {
                        Process.Start("explorer.exe");
                        Console.WriteLine("Windows Explorer yeniden başlatıldı.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Explorer'ı başlatırken hata oluştu: {ex.Message}");
                    }
                }
            }
        }
        else if (a == "2")
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1) Make Windows 10 Right Click Menu");
            Console.WriteLine("2) Make Windows 11 Right Click Menu");
            string b = Console.ReadLine();
            if (b != null)
            {
                if (b == "1")
                {
                    Console.WriteLine("Your transaction is being completed.. Please wait.");
                    Process.Start("cmd.exe", "/k reg add HKCU\\Software\\Classes\\CLSID\\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\\InprocServer32 /ve /d \"\" /f");
                    i++;
                    /*Console.WriteLine("Uygulamadan Çıkmak İçin Bir Tuşa Basın...");
                    Console.ReadKey();
                    return;*/
                    foreach (var process in Process.GetProcessesByName("explorer"))
                    {
                        try
                        {
                            process.Kill();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error terminating Explorer: {ex.Message}");
                        }
                    }

                    // Explorer'ı yeniden başlat
                    try
                    {
                        Process.Start("explorer.exe");
                        Console.WriteLine("Windows Explorer has restarted.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error starting Explorer: {ex.Message}");
                    }
                }
                else if (b == "2")
                {
                    Console.WriteLine("Your transaction is being completed.. Please wait.");
                    Process.Start("cmd.exe", "/k reg delete HKCU\\SOFTWARE\\Classes\\CLSID\\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2} /f");
                    i++;
                    /*Console.WriteLine("Uygulamadan Çıkmak İçin Bir Tuşa Basın...");
                    Console.ReadKey();
                    return;*/
                    foreach (var process in Process.GetProcessesByName("explorer"))
                    {
                        try
                        {
                            process.Kill();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error terminating Explorer: {ex.Message}");
                        }
                    }

                    // Explorer'ı yeniden başlat
                    try
                    {
                        Process.Start("explorer.exe");
                        Console.WriteLine("Windows Explorer has restarted.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error starting Explorer: {ex.Message}");
                    }
                }
            }
        }
    }
}while (i<=0);
