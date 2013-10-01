using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Atomizer
{
    public partial class MainWindow : Form
    {
        public static ElementBox[] ElementBoxes;
        public static Dictionary<Type, GroupBox> GroupBoxes;

        public static ElementViewBox viewBox;
        public static Activatable selectedElement;
        public static MainWindow MainWindowObject;

        private static AutoResetEvent KeyWait = new AutoResetEvent(false);
        private static ConcurrentQueue<char> TypingQueue = new ConcurrentQueue<char>();

        public MainWindow()
        {
            InitializeComponent();

            this.Text = "Atomizer";

            #region ElementBox Array Init
            ElementBoxes = new ElementBox[]
            {
                ElementBox1,
                ElementBox2,
                ElementBox3,
                ElementBox4,
                ElementBox5,
                ElementBox6,
                ElementBox7,
                ElementBox8,
                ElementBox9,
                ElementBox10,
                ElementBox11,
                ElementBox12,
                ElementBox13,
                ElementBox14,
                ElementBox15,
                ElementBox16,
                ElementBox17,
                ElementBox18,
                ElementBox19,
                ElementBox20,
                ElementBox21,
                ElementBox22,
                ElementBox23,
                ElementBox24,
                ElementBox25,
                ElementBox26,
                ElementBox27,
                ElementBox28,
                ElementBox29,
                ElementBox30,
                ElementBox31,
                ElementBox32,
                ElementBox33,
                ElementBox34,
                ElementBox35,
                ElementBox36,
                ElementBox37,
                ElementBox38,
                ElementBox39,
                ElementBox40,
                ElementBox41,
                ElementBox42,
                ElementBox43,
                ElementBox44,
                ElementBox45,
                ElementBox46,
                ElementBox47,
                ElementBox48,
                ElementBox49,
                ElementBox50,
                ElementBox51,
                ElementBox52,
                ElementBox53,
                ElementBox54,
                ElementBox55,
                ElementBox56,
                ElementBox57,
                ElementBox58,
                ElementBox59,
                ElementBox60,
                ElementBox61,
                ElementBox62,
                ElementBox63,
                ElementBox64,
                ElementBox65,
                ElementBox66,
                ElementBox67,
                ElementBox68,
                ElementBox69,
                ElementBox70,
                ElementBox71,
                ElementBox72,
                ElementBox73,
                ElementBox74,
                ElementBox75,
                ElementBox76,
                ElementBox77,
                ElementBox78,
                ElementBox79,
                ElementBox80,
                ElementBox81,
                ElementBox82,
                ElementBox83,
                ElementBox84,
                ElementBox85,
                ElementBox86,
                ElementBox87,
                ElementBox88,
                ElementBox89,
                ElementBox90,
                ElementBox91,
                ElementBox92,
                ElementBox93,
                ElementBox94,
                ElementBox95,
                ElementBox96,
                ElementBox97,
                ElementBox98,
                ElementBox99,
                ElementBox100,
                ElementBox101,
                ElementBox102,
                ElementBox103,
                ElementBox104,
                ElementBox105,
                ElementBox106,
                ElementBox107,
                ElementBox108,
                ElementBox109,
                ElementBox110,
                ElementBox111,
                ElementBox112,
                ElementBox113,
                ElementBox114,
                ElementBox115,
                ElementBox116,
                ElementBox117,
                ElementBox118,
            };

            foreach (Element element in ElementDatabase.elementList)
            {
                ElementBoxes[element.AtomicNumber - 1].SetElement(element);
            }
            #endregion

            #region GroupBoxs Dictionary Init
            GroupBoxes = new Dictionary<Type, GroupBox>()
            {
                {typeof(Metal), GroupBoxMetal},
                {typeof(AlkaliMetal), GroupBoxAlkali},
                {typeof(AlkalineEarthMetal), GroupBoxAlkalineEarth},
                {typeof(RareEarthMetal), GroupBoxRareEarth},
                {typeof(Lanthanide), GroupBoxLanthanide},
                {typeof(Actinide), GroupBoxActinide},
                {typeof(CoinageMetal), GroupBoxTransition},
                {typeof(VolatileMetal), GroupBoxTransition},
                {typeof(TransitionMetal), GroupBoxTransition},
                {typeof(PostTransitionMetal), GroupBoxPostTransition},
                {typeof(Metalloid), GroupBoxMetalloid},
                {typeof(NonMetal), GroupBoxNonMetal},
                {typeof(OtherNonMetal), GroupBoxOtherNonMetal},
                {typeof(Halogen), GroupBoxHalogen},
                {typeof(NobleGas), GroupBoxNobleGas},
            };

            GroupBoxMetal.SetClassification(typeof(Metal));
            GroupBoxAlkali.SetClassification(typeof(AlkaliMetal));
            GroupBoxAlkalineEarth.SetClassification(typeof(AlkalineEarthMetal));
            GroupBoxRareEarth.SetClassification(typeof(RareEarthMetal));
            GroupBoxLanthanide.SetClassification(typeof(Lanthanide));
            GroupBoxActinide.SetClassification(typeof(Actinide));
            GroupBoxTransition.SetClassification(typeof(TransitionMetal));
            GroupBoxPostTransition.SetClassification(typeof(PostTransitionMetal));
            GroupBoxMetalloid.SetClassification(typeof(Metalloid));
            GroupBoxNonMetal.SetClassification(typeof(NonMetal));
            GroupBoxOtherNonMetal.SetClassification(typeof(OtherNonMetal));
            GroupBoxHalogen.SetClassification(typeof(Halogen));
            GroupBoxNobleGas.SetClassification(typeof(NobleGas));
            #endregion

            #region ViewBox Init
            viewBox = ElementViewBox;
            viewBox.ClearElement();
            #endregion

            #region Searching Init
            MainWindowObject = this;

            Thread KeyHandlerThread = new Thread(new ThreadStart((Action)delegate()
                {
                    int lastKeyPress = Environment.TickCount;
                    char lastKey;
                    Element elem;
                    string inputString = "";
                    string displayString = "";

                    Thread.Sleep(1000);
                    while (true)
                    {
                        KeyWait.WaitOne();
                        if (Environment.TickCount - lastKeyPress > 1500)
                        {
                            inputString = "";
                        }

                        lastKeyPress = Environment.TickCount;

                        while (TypingQueue.TryDequeue(out lastKey))
                        {
                            if (lastKey == (char)Keys.Enter)
                            {
                                if (MainWindow.selectedElement != null)
                                {
                                    viewBox.Invoke((Action)delegate()
                                    {
                                        if (MainWindow.viewBox.Element == ((ElementBox)MainWindow.selectedElement).Element && MainWindow.viewBox.Locked)
                                            MainWindow.viewBox.Locked = false;
                                        else
                                        {
                                            MainWindow.viewBox.Locked = true;
                                            MainWindow.viewBox.SetElement(((ElementBox)MainWindow.selectedElement).Element);
                                        }
                                    });
                                }
                            }
                            else if (lastKey == (char)Keys.Back && inputString.Length != 0)
                                inputString = inputString.Substring(0, inputString.Length - 1);
                            else if (lastKey == (char)Keys.Escape)
                                inputString = "";
                            else if (char.IsLetterOrDigit(lastKey))
                            {
                                if (inputString.Length != 0)
                                    inputString += lastKey.ToString().ToLower();
                                else
                                    inputString = lastKey.ToString().ToUpper();
                            }
                        }

                        if (inputString == "")
                            displayString = "";
                        else
                        {
                            displayString = " - " + inputString;

                            if (ElementDatabase.elementDictionary.TryGetValue(inputString, out elem))
                            {
                                elem.Control.Invoke((Action)elem.Control.TryMakeActive);
                                displayString = " - " + elem.Name;
                            }
                            else
                            {
                                foreach (KeyValuePair<string, Element> entry in ElementDatabase.elementDictionary)
                                {
                                    if (entry.Key.Contains(inputString))
                                    {
                                        entry.Value.Control.Invoke((Action)entry.Value.Control.TryMakeActive);
                                        displayString = " - " + entry.Value.Name;
                                        break;
                                    }
                                }
                            }
                        }

                        MainWindowObject.Invoke((Action)delegate()
                        {
                            MainWindowObject.Text = "Atomizer" + displayString;
                        });
                    }
                }));
            KeyHandlerThread.IsBackground = true;
            KeyHandlerThread.Start();

            this.KeyPress += delegate(object sender, KeyPressEventArgs e)
            {
                e.Handled = true;
                TypingQueue.Enqueue(e.KeyChar);
                KeyWait.Set();
            };

            #endregion
        }


        [DllImport("user32.dll")]
        public static extern bool HideCaret(IntPtr hWnd);

    }
}
