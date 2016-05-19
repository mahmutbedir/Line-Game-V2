using Android.App;
using Android.Widget;
using Android.OS;
using Android;
using System;

namespace LineMasterV3
{
	[Activity (Label = "LineMasterV3", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		
	//	int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);






			SetContentView (Resource.Layout.GirisSayfasi);
			Button basla_butonu = FindViewById<Button> (Resource.Id.basla_buton);

			basla_butonu.Click+= delegate {

				SetContentView (Resource.Layout.BilgiGiris);
				// Set our view from the "main" layout resource
				EditText isimgiris1= FindViewById<EditText>(Resource.Id.editText1);
				Button buttongiris = FindViewById<Button> (Resource.Id.buton_hazir);
				EditText isimgiris2 = FindViewById<EditText> (Resource.Id.editText2);

				buttongiris.Click+= delegate {

					SetContentView (Resource.Layout.Main);

					TextView textview1 = FindViewById<TextView> ( Resource.Id.textView1);TextView textview2 = FindViewById<TextView> ( Resource.Id.textView2);TextView textview3 = FindViewById<TextView> ( Resource.Id.textView3);TextView textview4 = FindViewById<TextView> ( Resource.Id.textView4);TextView textview5 = FindViewById<TextView> ( Resource.Id.textView5);
					//*******************************************************************************

					
					textview1.Text=isimgiris1.Text;
					textview2.Text=isimgiris2.Text;
					//MAİN AXML deki bütün butonların tanıtımı


					//*********************************************************
					Button button11 = FindViewById<Button> (Resource.Id.button11);Button button12 = FindViewById<Button> (Resource.Id.button12);Button button13 = FindViewById<Button> (Resource.Id.button13);Button button14 = FindViewById<Button> (Resource.Id.button14);Button button15 = FindViewById<Button> (Resource.Id.button15);Button button16 = FindViewById<Button> (Resource.Id.button16);Button button17 = FindViewById<Button> (Resource.Id.button17);Button button18 = FindViewById<Button> (Resource.Id.button18);
					Button button21 = FindViewById<Button> (Resource.Id.button21);Button button22 = FindViewById<Button> (Resource.Id.button22);Button button23 = FindViewById<Button> (Resource.Id.button23);Button button24 = FindViewById<Button> (Resource.Id.button24);Button button25 = FindViewById<Button> (Resource.Id.button25);Button button26 = FindViewById<Button> (Resource.Id.button26);Button button27 = FindViewById<Button> (Resource.Id.button27);Button button28 = FindViewById<Button> (Resource.Id.button28);
					Button button31 = FindViewById<Button> (Resource.Id.button31);Button button32 = FindViewById<Button> (Resource.Id.button32);Button button33 = FindViewById<Button> (Resource.Id.button33);Button button34 = FindViewById<Button> (Resource.Id.button34);Button button35 = FindViewById<Button> (Resource.Id.button35);Button button36 = FindViewById<Button> (Resource.Id.button36);Button button37 = FindViewById<Button> (Resource.Id.button37);Button button38 = FindViewById<Button> (Resource.Id.button38);
					Button button41 = FindViewById<Button> (Resource.Id.button41);Button button42 = FindViewById<Button> (Resource.Id.button42);Button button43 = FindViewById<Button> (Resource.Id.button43);Button button44 = FindViewById<Button> (Resource.Id.button44);Button button45 = FindViewById<Button> (Resource.Id.button45);Button button46 = FindViewById<Button> (Resource.Id.button46);Button button47 = FindViewById<Button> (Resource.Id.button47);Button button48 = FindViewById<Button> (Resource.Id.button48);
					Button button51 = FindViewById<Button> (Resource.Id.button51);Button button52 = FindViewById<Button> (Resource.Id.button52);Button button53 = FindViewById<Button> (Resource.Id.button53);Button button54 = FindViewById<Button> (Resource.Id.button54);Button button55 = FindViewById<Button> (Resource.Id.button55);Button button56 = FindViewById<Button> (Resource.Id.button56);Button button57 = FindViewById<Button> (Resource.Id.button57);Button button58 = FindViewById<Button> (Resource.Id.button58);
					Button button61 = FindViewById<Button> (Resource.Id.button61);Button button62 = FindViewById<Button> (Resource.Id.button62);Button button63 = FindViewById<Button> (Resource.Id.button63);Button button64 = FindViewById<Button> (Resource.Id.button64);Button button65 = FindViewById<Button> (Resource.Id.button65);Button button66 = FindViewById<Button> (Resource.Id.button66);Button button67 = FindViewById<Button> (Resource.Id.button67);Button button68 = FindViewById<Button> (Resource.Id.button68);
					Button button71 = FindViewById<Button> (Resource.Id.button71);Button button72 = FindViewById<Button> (Resource.Id.button72);Button button73 = FindViewById<Button> (Resource.Id.button73);Button button74 = FindViewById<Button> (Resource.Id.button74);Button button75 = FindViewById<Button> (Resource.Id.button75);Button button76 = FindViewById<Button> (Resource.Id.button76);Button button77 = FindViewById<Button> (Resource.Id.button77);Button button78 = FindViewById<Button> (Resource.Id.button78);
					Button button81 = FindViewById<Button> (Resource.Id.button81);Button button82 = FindViewById<Button> (Resource.Id.button82);Button button83 = FindViewById<Button> (Resource.Id.button83);Button button84 = FindViewById<Button> (Resource.Id.button84);Button button85 = FindViewById<Button> (Resource.Id.button85);Button button86 = FindViewById<Button> (Resource.Id.button86);Button button87 = FindViewById<Button> (Resource.Id.button87);Button button88 = FindViewById<Button> (Resource.Id.button88);
					Button button91 = FindViewById<Button> (Resource.Id.button91);Button button92 = FindViewById<Button> (Resource.Id.button92);Button button93 = FindViewById<Button> (Resource.Id.button93);Button button94 = FindViewById<Button> (Resource.Id.button94);Button button95 = FindViewById<Button> (Resource.Id.button95);Button button96 = FindViewById<Button> (Resource.Id.button96);Button button97 = FindViewById<Button> (Resource.Id.button97);Button button98 = FindViewById<Button> (Resource.Id.button98);
					Button button101 = FindViewById<Button> (Resource.Id.button101);Button button102 = FindViewById<Button> (Resource.Id.button102);Button button103 = FindViewById<Button> (Resource.Id.button103);Button button104 = FindViewById<Button> (Resource.Id.button104);Button button105 = FindViewById<Button> (Resource.Id.button105);Button button106 = FindViewById<Button> (Resource.Id.button106);Button button107 = FindViewById<Button> (Resource.Id.button107);Button button108 = FindViewById<Button> (Resource.Id.button108);
					Button button111 = FindViewById<Button> (Resource.Id.button111);Button button112 = FindViewById<Button> (Resource.Id.button112);Button button113 = FindViewById<Button> (Resource.Id.button113);Button button114 = FindViewById<Button> (Resource.Id.button114);Button button115 = FindViewById<Button> (Resource.Id.button115);Button button116 = FindViewById<Button> (Resource.Id.button116);Button button117 = FindViewById<Button> (Resource.Id.button117);Button button118 = FindViewById<Button> (Resource.Id.button118);
					//*******************************************************************************
					//main.axml deki textviewların tanımlanması

				
				
			

			
			
























































			//BÜTÜN BUTONLARA AİT CLİCK OLAYLARI

			button21.Click += delegate {button21.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button31.Click += delegate {button31.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button41.Click += delegate {button41.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button51.Click += delegate {button51.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button61.Click += delegate {button61.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button71.Click += delegate {button71.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button81.Click += delegate {button81.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button91.Click += delegate {button91.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button101.Click += delegate {button101.SetBackgroundResource (Resource.Drawable.sol_alt_click);};
			//----------------------------------------------------------------------------------------
			button22.Click += delegate {button22.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button32.Click += delegate {button32.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button42.Click += delegate {button42.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button52.Click += delegate {button52.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button62.Click += delegate {button62.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button72.Click += delegate {button72.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button82.Click += delegate {button82.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button92.Click += delegate {button92.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button102.Click += delegate {button102.SetBackgroundResource (Resource.Drawable.sol_ust_click);};
			//----------------------------------------------------------------------------------------
			button23.Click += delegate {button23.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button33.Click += delegate {button33.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button43.Click += delegate {button43.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button53.Click += delegate {button53.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button63.Click += delegate {button63.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button73.Click += delegate {button73.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button83.Click += delegate {button83.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button93.Click += delegate {button93.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button103.Click += delegate {button103.SetBackgroundResource (Resource.Drawable.sol_alt_click);};
			//----------------------------------------------------------------------------------------
			button24.Click += delegate {button24.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button34.Click += delegate {button34.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button44.Click += delegate {button44.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button54.Click += delegate {button54.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button64.Click += delegate {button64.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button74.Click += delegate {button74.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button84.Click += delegate {button84.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button94.Click += delegate {button94.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button104.Click += delegate {button104.SetBackgroundResource (Resource.Drawable.sol_ust_click);};
			//----------------------------------------------------------------------------------------
			button25.Click += delegate {button25.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button35.Click += delegate {button35.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button45.Click += delegate {button45.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button55.Click += delegate {button55.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button65.Click += delegate {button65.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button75.Click += delegate {button75.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button85.Click += delegate {button85.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button95.Click += delegate {button95.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button105.Click += delegate {button105.SetBackgroundResource (Resource.Drawable.sol_alt_click);};
			//----------------------------------------------------------------------------------------
			button26.Click += delegate {button26.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button36.Click += delegate {button36.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button46.Click += delegate {button46.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button56.Click += delegate {button56.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button66.Click += delegate {button66.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button76.Click += delegate {button76.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button86.Click += delegate {button86.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button96.Click += delegate {button96.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button106.Click += delegate {button106.SetBackgroundResource (Resource.Drawable.sol_ust_click);};
			//----------------------------------------------------------------------------------------
			button27.Click += delegate {button27.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button37.Click += delegate {button37.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button47.Click += delegate {button47.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button57.Click += delegate {button57.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button67.Click += delegate {button67.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button77.Click += delegate {button77.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button87.Click += delegate {button87.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button97.Click += delegate {button97.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button107.Click += delegate {button107.SetBackgroundResource (Resource.Drawable.sol_alt_click);};
			//----------------------------------------------------------------------------------------
			button28.Click += delegate {button28.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button38.Click += delegate {button38.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button48.Click += delegate {button48.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button58.Click += delegate {button58.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button68.Click += delegate {button68.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button78.Click += delegate {button78.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button88.Click += delegate {button88.SetBackgroundResource (Resource.Drawable.sol_ust_click);};button98.Click += delegate {button98.SetBackgroundResource (Resource.Drawable.sol_alt_click);};button108.Click += delegate {button108.SetBackgroundResource (Resource.Drawable.sol_ust_click);};
	
			//*******************************************************************************

				};
			};
		
		}

		}

}


