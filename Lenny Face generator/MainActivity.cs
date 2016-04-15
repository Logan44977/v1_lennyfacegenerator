﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Lenny_Face_generator
{

    [Activity(Label = "Lenny Face Generator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
       
    {
        //creates global variables
        public static string strEarLeft = "(";
        public static string strEarRight = ")";
        public static string strMouth = " ͜ʖ";
        public static string strEyeLeft = " ͡°";
        public static string strEyeRight = " ͡°";

     
        //brings resources here
        Button Ears;
        Button Mouth;
        Button Eyes;
        Button RandomAll;
        Button ClipBoardButton;
        TextView TextLarge;
     

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);


            Ears = FindViewById<Button>(Resource.Id.Ears);
            Mouth = FindViewById<Button>(Resource.Id.Mouth);
            Eyes = FindViewById<Button>(Resource.Id.Eyes);
            RandomAll = FindViewById<Button>(Resource.Id.RandomAll);
            TextLarge = FindViewById<TextView>(Resource.Id.TextLarge);
            ClipBoardButton = FindViewById<Button>(Resource.Id.ClipboardButton);

            //click events
            Ears.Click += OnClick;
            Mouth.Click += TwoClick;
            Eyes.Click += ThreeClick;
            RandomAll.Click += FourClick;
            ClipBoardButton.Click += FiveClick;
        }
        
    void OnClick(object sender, EventArgs e)
        {
//declares a random number
            int RandomNumber;
            //creates a random number generation process
            Random randEar = new Random();
         RandomNumber = randEar.Next(1, 27);
            

            //creates an array for the left ear. Xamarin does not support multi-dimensional arrays 
            var LeftEar = new string[] { "q", "ʢ", "⸮","ʕ","ᖗ","ᕦ","ᕦ(","ᕙ(","ᘳ","ᕮ","ᕳ","(","[","¯\\_","୧","୨","⤜","☞",
               "ᑫ","ᑴ","ヽ(","\\(","乁(","└[","(づ","(ง","|",};
            //creates an array for the right ear
            var RightEar = new string[] {"p","ʡ","?","ʔ","ᖗ","ᕥ",")ᕥ",")ᕗ","ᘰ","ᕭ","ᕲ",")","]","_/¯","୨","୧","⤏","☞","ᑷ",
           "ᑷ",")ﾉ", ")/", ")ㄏ","]┘", ")づ",")ง","|"};

            //assigns the array element to the left & right ear variables
            strEarLeft = LeftEar[RandomNumber];
            strEarRight = RightEar[RandomNumber];

            //Assigns the variables to the text large resource and puts it in the middle
            TextLarge.Text = strEarLeft + strEyeLeft + strMouth + strEyeRight + strEarRight;
            TextLarge.TextAlignment = TextAlignment.Center;
        }
        

        void TwoClick(object sender, EventArgs e)
        {
            //declares a random number
            int RandomNumber;
            //creates a random number generation process
            Random randMouth = new Random();
            RandomNumber = randMouth.Next(1, 42);

            //creates a mouth array 
            var MouthString = new string[] { "v", "ᴥ", "ᗝ", "Ѡ", "ᗜ", "Ꮂ", "ᨓ", "ᨎ", "ヮ ]", "╭͜ʖ╮", " ͟ل͜", " ͜ʖ", " ͟ʖ", " ʖ̯",
                "ω", " ³ ", " ε ", "﹏", "□", "ل͜", "‿", "╭╮", "‿‿", "▾", "‸", "Д", "∀", "!", "人", ".", "ロ", "_", "෴", "ꔢ",
                "ѽ", "ഌ", "⏠", "⏏", "⍊", "⍘", "ツ", "益" };

            //assigns the array element to the mouth variable
            strMouth = MouthString[RandomNumber];

            //Assigns the variables to the text large resource
            TextLarge.Text = strEarLeft + strEyeLeft + strMouth + strEyeRight + strEarRight;
            TextLarge.TextAlignment = TextAlignment.Center;
        }

        void ThreeClick(object sender, EventArgs e)
        {
            int RandomNumber;
            //creates a random number generation process
            Random randEye = new Random();
            RandomNumber = randEye.Next(1, 92);

            //creates an eyes array
            var Lefteye = new string[]  {"⌐■"," ͠°","⇀","´•","´","`","ó","ò","⸌",">","Ƹ̵̡ ","ᗒ","⟃","⪧","⪦","⪩","⪨","⪰","⫑","⨴","⩿","⩾","⩺","⩹","◥▶","≋", "૦ઁ"," ͯ ",
            " ̿ "," ͌ ","ꗞ", "ꔸ", "꘠", "ꖘ","܍", "ළ","◉", "☉","・","▰", "ᵔ", " ﾟ","□","☼","*", "`","⚆","⊜",">","❍","￣","─", "✿","•", "T", "^", "ⱺ", "@", "ȍ", "  ",
            "  ","x","-","$","Ȍ","ʘ","Ꝋ","","","⸟","๏","ⴲ","■"," ﾟ","◕","◔","✧","■","♥"," ͡°","¬"," º ","⨶","⨱","⏓","⏒","⍜","⍤","ᚖ","ᴗ","ಠ","σ" };

            var Righteye = new string[]  {"■","°","↼","•`","`","´","ò","ó","⸍","<","Ʒ","ᗕ","⟄","⪦","⪧","⪨","⪩","⪯","⫒","⨵","⪀","⩽","⩹","⩺","◀◤","≋","૦ઁ"," ͯ ",
" ̿ "," ͌ ","ꗞ", "ꔸ","꘠","ꖘ","܍","ළ","◉","☉","・","▰","ᵔ"," ﾟ","□","☼","*","`","⚆","⊜",">","❍","￣","─","✿","•","T","^","ⱺ","@","ȍ","  ","  ","x","-","$","Ȍ",
"ʘ","Ꝋ","","","⸟","๏","ⴲ","■"," ﾟ","◕","◔","✧","■","♥"," ͡°","¬"," º ","⨶","⨱","⏓","⏒","⍜","⍤","ᚖ","ᴗ","ಠ","σ"};

            //assigns the array element to the eye variables
            strEyeLeft = Lefteye[RandomNumber];
            strEyeRight = Righteye[RandomNumber];

            //Assigns the variables to the text large resource
            TextLarge.Text = strEarLeft + strEyeLeft + strMouth + strEyeRight + strEarRight;
            TextLarge.TextAlignment = TextAlignment.Center;
        }

    void FourClick(object sender, EventArgs e)
        {
            //declares a random number
            int RandomNumber;
            //creates a random number generation process
            Random randEar = new Random();
            RandomNumber = randEar.Next(1, 27);


            //creates an array for the left ear. Xamarin does not support multi-dimensional arrays 
            var LeftEar = new string[] { "q", "ʢ", "⸮","ʕ","ᖗ","ᕦ","ᕦ(","ᕙ(","ᘳ","ᕮ","ᕳ","(","[","¯\\_","୧","୨","⤜","☞",
               "ᑫ","ᑴ","ヽ(","\\(","乁(","└[","(づ","(ง","|",};
            //creates an array for the right ear
            var RightEar = new string[] {"p","ʡ","?","ʔ","ᖗ","ᕥ",")ᕥ",")ᕗ","ᘰ","ᕭ","ᕲ",")","]","_/¯","୨","୧","⤏","☞","ᑷ",
           "ᑷ",")ﾉ", ")/", ")ㄏ","]┘", ")づ",")ง","|"};



            //declares a random number
            int RandomNumber1;
            //creates a random number generation process
            Random randMouth = new Random();
            RandomNumber1 = randMouth.Next(1, 42);

            //creates a mouth array 
            var MouthString = new string[] { "v", "ᴥ", "ᗝ", "Ѡ", "ᗜ", "Ꮂ", "ᨓ", "ᨎ", "ヮ ]", "╭͜ʖ╮", " ͟ل͜", " ͜ʖ", " ͟ʖ", " ʖ̯",
                "ω", " ³ ", " ε ", "﹏", "□", "ل͜", "‿", "╭╮", "‿‿", "▾", "‸", "Д", "∀", "!", "人", ".", "ロ", "_", "෴", "ꔢ",
                "ѽ", "ഌ", "⏠", "⏏", "⍊", "⍘", "ツ", "益" };

            int RandomNumber2;
            //creates a random number generation process
            Random randEye = new Random();
            RandomNumber2 = randEye.Next(1, 92);

            //creates an eyes array
            var Lefteye = new string[]  {"⌐■"," ͠°","⇀","´•","´","`","ó","ò","⸌",">","Ƹ̵̡ ","ᗒ","⟃","⪧","⪦","⪩","⪨","⪰","⫑","⨴","⩿","⩾","⩺","⩹","◥▶","≋", "૦ઁ"," ͯ ",
            " ̿ "," ͌ ","ꗞ", "ꔸ", "꘠", "ꖘ","܍", "ළ","◉", "☉","・","▰", "ᵔ", " ﾟ","□","☼","*", "`","⚆","⊜",">","❍","￣","─", "✿","•", "T", "^", "ⱺ", "@", "ȍ", "  ",
            "  ","x","-","$","Ȍ","ʘ","Ꝋ","","","⸟","๏","ⴲ","■"," ﾟ","◕","◔","✧","■","♥"," ͡°","¬"," º ","⨶","⨱","⏓","⏒","⍜","⍤","ᚖ","ᴗ","ಠ","σ" };

            var Righteye = new string[]  {"■","°","↼","•`","`","´","ò","ó","⸍","<","Ʒ","ᗕ","⟄","⪦","⪧","⪨","⪩","⪯","⫒","⨵","⪀","⩽","⩹","⩺","◀◤","≋","૦ઁ"," ͯ ",
" ̿ "," ͌ ","ꗞ", "ꔸ","꘠","ꖘ","܍","ළ","◉","☉","・","▰","ᵔ"," ﾟ","□","☼","*","`","⚆","⊜",">","❍","￣","─","✿","•","T","^","ⱺ","@","ȍ","  ","  ","x","-","$","Ȍ",
"ʘ","Ꝋ","","","⸟","๏","ⴲ","■"," ﾟ","◕","◔","✧","■","♥"," ͡°","¬"," º ","⨶","⨱","⏓","⏒","⍜","⍤","ᚖ","ᴗ","ಠ","σ"};


            //assigns the array element to the left & right ear variables
            strEarLeft = LeftEar[RandomNumber];
            strEarRight = RightEar[RandomNumber];

            //assigns the array element to the mouth variable
            strMouth = MouthString[RandomNumber];

            //assigns the array element to the eye variables
            strEyeLeft = Lefteye[RandomNumber];
            strEyeRight = Righteye[RandomNumber];


            //Assigns the variables to the text large resource
            TextLarge.Text = strEarLeft + strEyeLeft + strMouth + strEyeRight + strEarRight;
            TextLarge.TextAlignment = TextAlignment.Center;

        }

        void FiveClick(object sender, EventArgs e)
        {

            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", TextLarge.Text);

            clipboard.PrimaryClip = clip;
        }
}
}

