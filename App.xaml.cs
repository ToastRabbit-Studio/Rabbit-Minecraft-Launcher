using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Natsurainko.FluentCore.Class.Model.Auth;
using Natsurainko.FluentCore.Class.Model.Launch;
using Natsurainko.FluentCore.Event;
using Natsurainko.FluentCore.Extension.Windows.Class.Model.Launch;
using Natsurainko.FluentCore.Interface;
using Natsurainko.FluentCore.Module.Authenticator;
using Natsurainko.FluentCore.Module.Downloader;
using Natsurainko.FluentCore.Module.Installer;
using Natsurainko.FluentCore.Module.Launcher;
using Natsurainko.FluentCore.Module.Mod;
using Natsurainko.FluentCore.Service;
using Natsurainko.FluentCore.Wrapper;
using Natsurainko.Toolkits.Network.Downloader;
using Natsurainko.Toolkits.Network.Downloader.Model;
using Natsurainko.Toolkits.Values;

namespace Rabbit_Minecraft_Launcher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
    }
}
