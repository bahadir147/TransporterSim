using System.Collections;
using UnityEngine;
using UnityEditor;

namespace Michsky.UI.ModernUIPack
{
    public class MUIPEditor : MonoBehaviour
    {

        [MenuItem("GameObject/Modern UI Pack/Animated Icons/Hamburger to Exit", false, 0)]
        static void AIHTE()
        {
            Instantiate(Resources.Load<GameObject>("Animated Icons/Hamburger to Exit")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Animated Icons/Heart Pop", false, 0)]
        static void AIHP()
        {
            Instantiate(Resources.Load<GameObject>("Animated Icons/Heart Pop")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Animated Icons/Lock", false, 0)]
        static void AIL()
        {
            Instantiate(Resources.Load<GameObject>("Animated Icons/Lock")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Animated Icons/Message Bubbles", false, 0)]
        static void AILMB()
        {
            Instantiate(Resources.Load<GameObject>("Animated Icons/Message Bubbles")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Animated Icons/Sand Clock", false, 0)]
        static void AISC()
        {
            Instantiate(Resources.Load<GameObject>("Animated Icons/Sand Clock")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Animated Icons/Switch", false, 0)]
        static void AIS()
        {
            Instantiate(Resources.Load<GameObject>("Animated Icons/Switch")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Animated Icons/Yes to No", false, 0)]
        static void AIYTN()
        {
            Instantiate(Resources.Load<GameObject>("Animated Icons/Yes to No")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic/Blue", false, 0)]
        static void BBBL()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic/Blue")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic/Brown", false, 0)]
        static void BBBRW()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic/Brown")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic/Gray", false, 0)]
        static void BBGR()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic/Gray")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic/Green", false, 0)]
        static void BBGRE()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic/Green")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic/Night", false, 0)]
        static void BBNI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic/Night")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic/Orange", false, 0)]
        static void BBOR()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic/Orange")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic/Pink", false, 0)]
        static void BBPIN()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic/Pink")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic/Purple", false, 0)]
        static void BBPURP()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic/Purple")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic/Red", false, 0)]
        static void BBRED()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic/Red")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic/White", false, 0)]
        static void BBWHI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic/White")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Gradient/Blue", false, 0)]
        static void BGBL()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Gradient/Blue")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Gradient/Brown", false, 0)]
        static void BGBRW()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Gradient/Brown")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Gradient/Gray", false, 0)]
        static void BGGR()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Gradient/Gray")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Gradient/Green", false, 0)]
        static void BGGRE()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Gradient/Green")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Gradient/Night", false, 0)]
        static void BGNI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Gradient/Night")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Gradient/Orange", false, 0)]
        static void BGOR()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Gradient/Orange")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Gradient/Pink", false, 0)]
        static void BGPIN()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Gradient/Pink")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Gradient/Purple", false, 0)]
        static void BGPURP()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Gradient/Purple")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Gradient/Red", false, 0)]
        static void BGRED()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Gradient/Red")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Gradient/White", false, 0)]
        static void BGWHI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Gradient/White")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline/Blue", false, 0)]
        static void BOBL()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline/Blue")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline/Brown", false, 0)]
        static void BOBRW()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline/Brown")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline/Gray", false, 0)]
        static void BOGR()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline/Gray")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline/Green", false, 0)]
        static void BOGRE()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline/Green")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline/Night", false, 0)]
        static void BONI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline/Night")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline/Orange", false, 0)]
        static void BOOR()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline/Orange")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline/Pink", false, 0)]
        static void BOPIN()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline/Pink")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline/Purple", false, 0)]
        static void BOPURP()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline/Purple")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline/Red", false, 0)]
        static void BORED()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline/Red")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline/White", false, 0)]
        static void BOWHI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline/White")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline Gradient/Blue", false, 0)]
        static void BOGBL()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline Gradient/Blue")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline Gradient/Brown", false, 0)]
        static void BOGBRW()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline Gradient/Brown")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline Gradient/Gray", false, 0)]
        static void BOGBGR()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline Gradient/Gray")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline Gradient/Green", false, 0)]
        static void BOGGRE()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline Gradient/Green")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline Gradient/Night", false, 0)]
        static void BOGNI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline Gradient/Night")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline Gradient/Orange", false, 0)]
        static void BOGOR()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline Gradient/Orange")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline Gradient/Pink", false, 0)]
        static void BOGPIN()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline Gradient/Pink")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline Gradient/Purple", false, 0)]
        static void BOGPURP()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline Gradient/Purple")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline Gradient/Red", false, 0)]
        static void BOGRED()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline Gradient/Red")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline Gradient/White", false, 0)]
        static void BOGWHI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline Gradient/White")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline With Image/Gray", false, 0)]
        static void BOWIGRA()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline With Image/Gray")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Basic Outline With Image/White", false, 0)]
        static void BOWIWHI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Basic Outline With Image/White")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Box Outline With Image/Gray", false, 0)]
        static void BOXIGRA()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Box Outline With Image/Gray")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Box Outline With Image/White", false, 0)]
        static void BOXIWHI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Box Outline With Image/White")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Box With Image/Gray", false, 0)]
        static void CIRGRA()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Box With Image/Gray")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Box With Image/White", false, 0)]
        static void CIRWHI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Box With Image/White")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Circle Outline With Image/Gray", false, 0)]
        static void CIRCOGRA()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Circle Outline With Image/Gray")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Circle Outline With Image/White", false, 0)]
        static void CIRCOWHI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Circle Outline With Image/White")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Circle With Image/Gray", false, 0)]
        static void CIRCGRA()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Circle With Image/Gray")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Circle With Image/White", false, 0)]
        static void CIRCWHI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Circle With Image/White")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded/Blue", false, 0)]
        static void ROBL()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded/Blue")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded/Brown", false, 0)]
        static void ROBRW()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded/Brown")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded/Gray", false, 0)]
        static void ROGR()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded/Gray")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded/Green", false, 0)]
        static void ROGRE()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded/Green")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded/Night", false, 0)]
        static void RONI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded/Night")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded/Orange", false, 0)]
        static void ROOR()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded/Orange")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded/Pink", false, 0)]
        static void ROPIN()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded/Pink")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded/Purple", false, 0)]
        static void ROPURP()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded/Purple")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded/Red", false, 0)]
        static void RORED()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded/Red")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded/White", false, 0)]
        static void ROWHI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded/White")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Gradient/Blue", false, 0)]
        static void RGBL()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Gradient/Blue")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Gradient/Brown", false, 0)]
        static void RGBRW()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Gradient/Brown")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Gradient/Gray", false, 0)]
        static void RGGR()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Gradient/Gray")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Gradient/Green", false, 0)]
        static void RGGRE()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Gradient/Green")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Gradient/Night", false, 0)]
        static void RGNI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Gradient/Night")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Gradient/Orange", false, 0)]
        static void RGOR()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Gradient/Orange")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Gradient/Pink", false, 0)]
        static void RGPIN()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Gradient/Pink")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Gradient/Purple", false, 0)]
        static void RGPURP()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Gradient/Purple")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Gradient/Red", false, 0)]
        static void RGRED()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Gradient/Red")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Gradient/White", false, 0)]
        static void RGWHI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Gradient/White")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline/Blue", false, 0)]
        static void ROBLU()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline/Blue")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline/Brown", false, 0)]
        static void RORW()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline/Brown")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline/Gray", false, 0)]
        static void ROR()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline/Gray")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline/Green", false, 0)]
        static void RORE()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline/Green")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline/Night", false, 0)]
        static void RONIG()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline/Night")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline/Orange", false, 0)]
        static void ROORA()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline/Orange")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline/Pink", false, 0)]
        static void ROPINK()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline/Pink")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline/Purple", false, 0)]
        static void ROPURPL()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline/Purple")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline/Red", false, 0)]
        static void ROREDD()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline/Red")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline/White", false, 0)]
        static void ROWHIT()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline/White")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline Gradient/Blue", false, 0)]
        static void ROGBL()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline Gradient/Blue")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline Gradient/Brown", false, 0)]
        static void ROGRW()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline Gradient/Brown")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline Gradient/Gray", false, 0)]
        static void ROGRAY()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline Gradient/Gray")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline Gradient/Green", false, 0)]
        static void ROGREE()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline Gradient/Green")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline Gradient/Night", false, 0)]
        static void ROGNI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline Gradient/Night")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline Gradient/Orange", false, 0)]
        static void ROGOR()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline Gradient/Orange")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline Gradient/Pink", false, 0)]
        static void ROGPIN()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline Gradient/Pink")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline Gradient/Purple", false, 0)]
        static void ROGPURP()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline Gradient/Purple")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline Gradient/Red", false, 0)]
        static void ROGRED()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline Gradient/Red")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline Gradient/White", false, 0)]
        static void ROGWHI()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline Gradient/White")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline With Image/Gray", false, 0)]
        static void ROWIGRA()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline With Image/Gray")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded Outline With Image/White", false, 0)]
        static void ROWIWHIT()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded Outline With Image/White")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded With Image/Gray", false, 0)]
        static void RWIGRAY()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded With Image/Gray")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Buttons/Rounded With Image/White", false, 0)]
        static void RWIWHIT()
        {
            Instantiate(Resources.Load<GameObject>("Buttons/Rounded With Image/White")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Dropdowns/Legacy Outline Dropdown", false, 0)]
        static void DRPLOD()
        {
            Instantiate(Resources.Load<GameObject>("Dropdowns/Legacy Outline Dropdown")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Dropdowns/Outline Dropdown", false, 0)]
        static void DRPOD()
        {
            Instantiate(Resources.Load<GameObject>("Dropdowns/Outline Dropdown")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Dropdowns/Standard Dropdown", false, 0)]
        static void DRPSD()
        {
            Instantiate(Resources.Load<GameObject>("Dropdowns/Standard Dropdown")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Input Fields/Fading Input Field (Left Aligned)", false, 0)]
        static void IFFIFL()
        {
            Instantiate(Resources.Load<GameObject>("Input Fields/Fading Input Field (Left Aligned)")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Input Fields/Fading Input Field (Middle Aligned)", false, 0)]
        static void IFFIFM()
        {
            Instantiate(Resources.Load<GameObject>("Input Fields/Fading Input Field (Middle Aligned)")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Input Fields/Fading Input Field (Right Aligned)", false, 0)]
        static void IFFIFR()
        {
            Instantiate(Resources.Load<GameObject>("Input Fields/Fading Input Field (Right Aligned)")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Input Fields/Standard Input Field (Left Aligned)", false, 0)]
        static void IFSIFL()
        {
            Instantiate(Resources.Load<GameObject>("Input Fields/Standard Input Field (Left Aligned)")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Input Fields/Standard Input Field (Middle Aligned)", false, 0)]
        static void IFSIFM()
        {
            Instantiate(Resources.Load<GameObject>("Input Fields/Standard Input Field (Middle Aligned)")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Input Fields/Standard Input Field (Right Aligned)", false, 0)]
        static void IFSIFR()
        {
            Instantiate(Resources.Load<GameObject>("Input Fields/Standard Input Field (Right Aligned)")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Modal Windows/Modal & Notification Canvas", false, 0)]
        static void MWMNC()
        {
            Instantiate(Resources.Load<GameObject>("Modal Windows/Modal & Notification Canvas")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Modal Windows/Style 1/Auto-Resizing", false, 0)]
        static void MWSOAR()
        {
            Instantiate(Resources.Load<GameObject>("Modal Windows/Style 1/Auto-Resizing")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Modal Windows/Style 1/Standard", false, 0)]
        static void MWSOS()
        {
            Instantiate(Resources.Load<GameObject>("Modal Windows/Style 1/Standard")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Modal Windows/Style 1/With Buttons", false, 0)]
        static void MWSOWB()
        {
            Instantiate(Resources.Load<GameObject>("Modal Windows/Style 1/With Buttons")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Modal Windows/Style 1/With Tabs", false, 0)]
        static void MWSOWT()
        {
            Instantiate(Resources.Load<GameObject>("Modal Windows/Style 1/With Tabs")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Modal Windows/Style 2/Standard", false, 0)]
        static void MWSTS()
        {
            Instantiate(Resources.Load<GameObject>("Modal Windows/Style 2/Standard")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Modal Windows/Style 2/With Tabs", false, 0)]
        static void MWSTWT()
        {
            Instantiate(Resources.Load<GameObject>("Modal Windows/Style 2/With Tabs")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Notifications/Fading Notification", false, 0)]
        static void NFN()
        {
            Instantiate(Resources.Load<GameObject>("Notifications/Fading Notification")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Notifications/Icon Popup Bottom Left", false, 0)]
        static void NIPBL()
        {
            Instantiate(Resources.Load<GameObject>("Notifications/Icon Popup Bottom Left")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Notifications/Icon Popup Bottom Right", false, 0)]
        static void NIPBR()
        {
            Instantiate(Resources.Load<GameObject>("Notifications/Icon Popup Bottom Right")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Notifications/Icon Popup Top Left", false, 0)]
        static void NIPTL()
        {
            Instantiate(Resources.Load<GameObject>("Notifications/Icon Popup Top Left")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Notifications/Icon Popup Top Right", false, 0)]
        static void NIPTR()
        {
            Instantiate(Resources.Load<GameObject>("Notifications/Icon Popup Top Right")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Notifications/Popup Notification", false, 0)]
        static void NPN()
        {
            Instantiate(Resources.Load<GameObject>("Notifications/Popup Notification")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Notifications/Slippery Notification", false, 0)]
        static void NSN()
        {
            Instantiate(Resources.Load<GameObject>("Notifications/Slippery Notification")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Notifications/Slipping Notification", false, 0)]
        static void NSLN()
        {
            Instantiate(Resources.Load<GameObject>("Notifications/Slipping Notification")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Progress Bars/Radial PB Bold", false, 0)]
        static void PBRPB()
        {
            Instantiate(Resources.Load<GameObject>("Progress Bars/Radial PB Bold")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Progress Bars/Radial PB Filled H", false, 0)]
        static void PBRPF()
        {
            Instantiate(Resources.Load<GameObject>("Progress Bars/Radial PB Filled H")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Progress Bars/Radial PB Filled V", false, 0)]
        static void PBRPV()
        {
            Instantiate(Resources.Load<GameObject>("Progress Bars/Radial PB Filled V")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Progress Bars/Radial PB Light", false, 0)]
        static void PBRPLI()
        {
            Instantiate(Resources.Load<GameObject>("Progress Bars/Radial PB Light")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Progress Bars/Radial PB Regular", false, 0)]
        static void PBRPREG()
        {
            Instantiate(Resources.Load<GameObject>("Progress Bars/Radial PB Regular")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Progress Bars/Radial PB Thin", false, 0)]
        static void PBRPTHI()
        {
            Instantiate(Resources.Load<GameObject>("Progress Bars/Radial PB Thin")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Progress Bars/Standard PB", false, 0)]
        static void PBSPB()
        {
            Instantiate(Resources.Load<GameObject>("Progress Bars/Standard PB")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Progress Bars (Loop)/Circle Arround", false, 0)]
        static void PBLCA()
        {
            Instantiate(Resources.Load<GameObject>("Progress Bars (Loop)/Circle Arround")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Progress Bars (Loop)/Circle Glass", false, 0)]
        static void PBLCG()
        {
            Instantiate(Resources.Load<GameObject>("Progress Bars (Loop)/Circle Glass")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Progress Bars (Loop)/Circle Pie", false, 0)]
        static void PBLPIE()
        {
            Instantiate(Resources.Load<GameObject>("Progress Bars (Loop)/Circle Pie")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Progress Bars (Loop)/Circle Run", false, 0)]
        static void PBLRUN()
        {
            Instantiate(Resources.Load<GameObject>("Progress Bars (Loop)/Circle Run")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Progress Bars (Loop)/Standard Fastly", false, 0)]
        static void PBLSF()
        {
            Instantiate(Resources.Load<GameObject>("Progress Bars (Loop)/Standard Fastly")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Progress Bars (Loop)/Standard Finish", false, 0)]
        static void PBLSFIN()
        {
            Instantiate(Resources.Load<GameObject>("Progress Bars (Loop)/Standard Finish")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Progress Bars (Loop)/Standard Run", false, 0)]
        static void PBLSRUN()
        {
            Instantiate(Resources.Load<GameObject>("Progress Bars (Loop)/Standard Run")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Sliders/Gradient", false, 0)]
        static void SLGR()
        {
            Instantiate(Resources.Load<GameObject>("Sliders/Gradient")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Sliders/Gradient (Popup)", false, 0)]
        static void SLGRP()
        {
            Instantiate(Resources.Load<GameObject>("Sliders/Gradient (Popup)")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Sliders/Gradient (Value)", false, 0)]
        static void SLGRV()
        {
            Instantiate(Resources.Load<GameObject>("Sliders/Gradient (Value)")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Sliders/Outline", false, 0)]
        static void SLO()
        {
            Instantiate(Resources.Load<GameObject>("Sliders/Outline")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Sliders/Outline (Popup)", false, 0)]
        static void SLOP()
        {
            Instantiate(Resources.Load<GameObject>("Sliders/Outline (Popup)")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Sliders/Outline (Value)", false, 0)]
        static void SLOV()
        {
            Instantiate(Resources.Load<GameObject>("Sliders/Outline (Value)")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Sliders/Radial Gradient", false, 0)]
        static void SLRG()
        {
            Instantiate(Resources.Load<GameObject>("Sliders/Radial Gradient")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Sliders/Radial Standard", false, 0)]
        static void SLRS()
        {
            Instantiate(Resources.Load<GameObject>("Sliders/Radial Standard")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Sliders/Standard", false, 0)]
        static void SLSTA()
        {
            Instantiate(Resources.Load<GameObject>("Sliders/Standard")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Sliders/Standard (Popup)", false, 0)]
        static void SLSTAP()
        {
            Instantiate(Resources.Load<GameObject>("Sliders/Standard (Popup)")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Sliders/Standard (Value)", false, 0)]
        static void SLSTAV()
        {
            Instantiate(Resources.Load<GameObject>("Sliders/Standard (Value)")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Switches/Material", false, 0)]
        static void SWMAT()
        {
            Instantiate(Resources.Load<GameObject>("Switches/Material")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Switches/Standard", false, 0)]
        static void SWST()
        {
            Instantiate(Resources.Load<GameObject>("Switches/Standard")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Switches/Standard With Label", false, 0)]
        static void SWSTL()
        {
            Instantiate(Resources.Load<GameObject>("Switches/Standard With Label")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Toggles/Standard Toggle (Bold)", false, 0)]
        static void TSTB()
        {
            Instantiate(Resources.Load<GameObject>("Toggles/Standard Toggle (Bold)")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Toggles/Standard Toggle (Light)", false, 0)]
        static void TSTL()
        {
            Instantiate(Resources.Load<GameObject>("Toggles/Standard Toggle (Light)")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Toggles/Standard Toggle (Regular)", false, 0)]
        static void TSTR()
        {
            Instantiate(Resources.Load<GameObject>("Toggles/Standard Toggle (Regular)")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Toggles/Toggle Group Panel", false, 0)]
        static void TSTTG()
        {
            Instantiate(Resources.Load<GameObject>("Toggles/Toggle Group Panel")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Tool Tips/Fading Tool Tip", false, 0)]
        static void TPFTP()
        {
            Instantiate(Resources.Load<GameObject>("Tool Tips/Fading Tool Tip")).GetComponent<MUIPEditor>();
        }

        [MenuItem("GameObject/Modern UI Pack/Tool Tips/Scaling Tool Tip", false, 0)]
        static void TPSTP()
        {
            Instantiate(Resources.Load<GameObject>("Tool Tips/Scaling Tool Tip")).GetComponent<MUIPEditor>();
        }
    }
}