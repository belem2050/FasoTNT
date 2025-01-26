using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using FasoTNT.ViewModels;
using System.Collections.ObjectModel;

namespace FasoTNT
{
    public sealed class SystemManager: ObservableObject
    {

        private static object _lockInstance = new object();
        static private SystemManager? _instance = null;

        public TvStation CurrentTvStation { get; set; } = new TvStation();

        public MediaElement CurrentMediaElement { get; set; }

        public ObservableCollection<TvStation> TvStations { get; private set; } = new ObservableCollection<TvStation>();


        public SystemManager() 
        {
            _instance = this;
        }

        public static SystemManager GetInstance()
        {
            lock(_lockInstance)
            {
                if( _instance == null )
                {
                   return _instance = new SystemManager();
                }
                    return _instance;
            }
        }
    }
}
