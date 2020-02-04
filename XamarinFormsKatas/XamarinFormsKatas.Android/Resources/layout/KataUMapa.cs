/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Gms;

namespace XamarinFormsKatas.Droid.Resources.layout
{
    [Activity(Label = "KataUMapa")]
    public class KataUMapa : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.KataUMapa);

            var mapFragment = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
            mapFragment.GetMapAsync(this);

        }
        
        public void OnMapReady(GoogleMap map)
        {
            map.MapType = GoogleMap.Normal;//tipo de mapa visualizado

            //Marca de Fesac
            MarkerOptions MarcaFesac = new MarkerOptions();
            MarcaFesac.SetPosition(new LatLng(37.371685, -5.999560));
            MarcaFesac.SetTitle("Fesac");
            map.AddMarker(MarcaFesac);

            //Marca de Estadio Sevilla
            MarkerOptions MarcaSevilla = new MarkerOptions();
            MarcaSevilla.SetPosition(new LatLng(37.383895, -5.970646));
            MarcaSevilla.SetTitle("Estadio Sevilla");
            map.AddMarker(MarcaSevilla);

            //Marca de Estadio Betis
            MarkerOptions MarcaBetis = new MarkerOptions();
            MarcaBetis.SetPosition(new LatLng(37.356444, -5.981623));
            MarcaBetis.SetTitle("Estadio Betis");
            map.AddMarker(MarcaBetis);
        }
    }
}*/