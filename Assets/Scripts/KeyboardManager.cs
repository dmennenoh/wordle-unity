using UnityEngine;

namespace wordleUnity
{
    public class KeyboardManager : MonoBehaviour
    {
        [SerializeField] private InputManager inputManager;

        [SerializeField] private Key A;
        [SerializeField] private Key B;
        [SerializeField] private Key C;
        [SerializeField] private Key D;
        [SerializeField] private Key E;
        [SerializeField] private Key F;
        [SerializeField] private Key G;
        [SerializeField] private Key H;
        [SerializeField] private Key I;
        [SerializeField] private Key J;
        [SerializeField] private Key K;
        [SerializeField] private Key L;
        [SerializeField] private Key M;
        [SerializeField] private Key N;
        [SerializeField] private Key O;
        [SerializeField] private Key P;
        [SerializeField] private Key Q;
        [SerializeField] private Key R;
        [SerializeField] private Key S;
        [SerializeField] private Key T;
        [SerializeField] private Key U;
        [SerializeField] private Key V;
        [SerializeField] private Key W;
        [SerializeField] private Key X;
        [SerializeField] private Key Y;
        [SerializeField] private Key Z;

        public void SetKeyState(string key, string color)
        {
            key = key.ToUpper();//this is the key the user typed in
            
            switch (key)
            {
                case "A":
                    switch (color)
                    {
                        case "G":
                            A.SetGreen();
                            break;
                        case "Y":
                            A.SetYellow();
                            break;
                        case "B":
                            A.SetGray();
                            break;
                    }
                    break;
                case "B":
                    switch (color)
                    {
                        case "G":
                            B.SetGreen();
                            break;
                        case "Y":
                            B.SetYellow();
                            break;
                        case "B":
                            B.SetGray();
                            break;
                    }
                    break;
                case "C":
                    switch (color)
                    {
                        case "G":
                            C.SetGreen();
                            break;
                        case "Y":
                            C.SetYellow();
                            break;
                        case "B":
                            C.SetGray();
                            break;
                    }
                    break;
                case "D":
                    switch (color)
                    {
                        case "G":
                            D.SetGreen();
                            break;
                        case "Y":
                            D.SetYellow();
                            break;
                        case "B":
                            D.SetGray();
                            break;
                    }
                    break;
                case "E":
                    switch (color)
                    {
                        case "G":
                            E.SetGreen();
                            break;
                        case "Y":
                            E.SetYellow();
                            break;
                        case "B":
                            E.SetGray();
                            break;
                    }
                    break;
                case "F":
                    switch (color)
                    {
                        case "G":
                            F.SetGreen();
                            break;
                        case "Y":
                            F.SetYellow();
                            break;
                        case "B":
                            F.SetGray();
                            break;
                    }
                    break;
                case "G":
                    switch (color)
                    {
                        case "G":
                            G.SetGreen();
                            break;
                        case "Y":
                            G.SetYellow();
                            break;
                        case "B":
                            G.SetGray();
                            break;
                    }
                    break;
                case "H":
                    switch (color)
                    {
                        case "G":
                            H.SetGreen();
                            break;
                        case "Y":
                            H.SetYellow();
                            break;
                        case "B":
                            H.SetGray();
                            break;
                    }
                    break;
                case "I":
                    switch (color)
                    {
                        case "G":
                            I.SetGreen();
                            break;
                        case "Y":
                            I.SetYellow();
                            break;
                        case "B":
                            I.SetGray();
                            break;
                    }
                    break;
                case "J":
                    switch (color)
                    {
                        case "G":
                            J.SetGreen();
                            break;
                        case "Y":
                            J.SetYellow();
                            break;
                        case "B":
                            J.SetGray();
                            break;
                    }
                    break;
                case "K":
                    switch (color)
                    {
                        case "G":
                            K.SetGreen();
                            break;
                        case "Y":
                            K.SetYellow();
                            break;
                        case "B":
                            K.SetGray();
                            break;
                    }
                    break;
                case "L":
                    switch (color)
                    {
                        case "G":
                            L.SetGreen();
                            break;
                        case "Y":
                            L.SetYellow();
                            break;
                        case "B":
                            L.SetGray();
                            break;
                    }
                    break;
                case "M":
                    switch (color)
                    {
                        case "G":
                            M.SetGreen();
                            break;
                        case "Y":
                            M.SetYellow();
                            break;
                        case "B":
                            M.SetGray();
                            break;
                    }
                    break;
                case "N":
                    switch (color)
                    {
                        case "G":
                            N.SetGreen();
                            break;
                        case "Y":
                            N.SetYellow();
                            break;
                        case "B":
                            N.SetGray();
                            break;
                    }
                    break;
                case "O":
                    switch (color)
                    {
                        case "G":
                            O.SetGreen();
                            break;
                        case "Y":
                            O.SetYellow();
                            break;
                        case "B":
                            O.SetGray();
                            break;
                    }
                    break;
                case "P":
                    switch (color)
                    {
                        case "G":
                            P.SetGreen();
                            break;
                        case "Y":
                            P.SetYellow();
                            break;
                        case "B":
                            P.SetGray();
                            break;
                    }
                    break;
                case "Q":
                    switch (color)
                    {
                        case "G":
                            Q.SetGreen();
                            break;
                        case "Y":
                            Q.SetYellow();
                            break;
                        case "B":
                            Q.SetGray();
                            break;
                    }
                    break;
                case "R":
                    switch (color)
                    {
                        case "G":
                            R.SetGreen();
                            break;
                        case "Y":
                            R.SetYellow();
                            break;
                        case "B":
                            R.SetGray();
                            break;
                    }
                    break;
                case "S":
                    switch (color)
                    {
                        case "G":
                            S.SetGreen();
                            break;
                        case "Y":
                            S.SetYellow();
                            break;
                        case "B":
                            S.SetGray();
                            break;
                    }
                    break;
                case "T":
                    switch (color)
                    {
                        case "G":
                            T.SetGreen();
                            break;
                        case "Y":
                            T.SetYellow();
                            break;
                        case "B":
                            T.SetGray();
                            break;
                    }
                    break;
                case "U":
                    switch (color)
                    {
                        case "G":
                            U.SetGreen();
                            break;
                        case "Y":
                            U.SetYellow();
                            break;
                        case "B":
                            U.SetGray();
                            break;
                    }
                    break;
                case "V":
                    switch (color)
                    {
                        case "G":
                            V.SetGreen();
                            break;
                        case "Y":
                            V.SetYellow();
                            break;
                        case "B":
                            V.SetGray();
                            break;
                    }
                    break;
                case "W":
                    switch (color)
                    {
                        case "G":
                            W.SetGreen();
                            break;
                        case "Y":
                            W.SetYellow();
                            break;
                        case "B":
                            W.SetGray();
                            break;
                    }
                    break;
                case "X":
                    switch (color)
                    {
                        case "G":
                            X.SetGreen();
                            break;
                        case "Y":
                            X.SetYellow();
                            break;
                        case "B":
                            X.SetGray();
                            break;
                    }
                    break;
                case "Y":
                    switch (color)
                    {
                        case "G":
                            Y.SetGreen();
                            break;
                        case "Y":
                            Y.SetYellow();
                            break;
                        case "B":
                            Y.SetGray();
                            break;
                    }
                    break;
                case "Z":
                    switch (color)
                    {
                        case "G":
                            Z.SetGreen();
                            break;
                        case "Y":
                            Z.SetYellow();
                            break;
                        case "B":
                            Z.SetGray();
                            break;
                    }
                    break;
            }
        }
    }
}