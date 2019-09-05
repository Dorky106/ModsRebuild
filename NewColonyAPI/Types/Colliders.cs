using Pipliz;
using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.Types
{
    public class Collider
    {
        public static List<BoundsPip> GetColliders(string shape)
        {
            ColliderData ret = new ColliderData();
            List<BoundsPip> bounds = new List<BoundsPip>();
            BoundsPip tmp = new BoundsPip();
            switch (shape)
            {
                case "slopex-":
                case "fourstepstairsx-":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, -0.25f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.25f, -0.25f, -0.5f), new UnityEngine.Vector3(0.5f, 0f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(0f, 0f, -0.5f), new UnityEngine.Vector3(0.5f, 0.25f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(0.25f, 0.25f, -0.5f), new UnityEngine.Vector3(0.5f, 0.5f, 0.5f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                case "slopex+":
                case "fourstepstairsx+":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, -0.25f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.25f, -0.5f), new UnityEngine.Vector3(0.25f, 0f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, 0f, -0.5f), new UnityEngine.Vector3(0f, 0.25f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, 0.25f, -0.5f), new UnityEngine.Vector3(-0.25f, 0.5f, 0.5f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                case "slopez-":
                case "fourstepstairsz-":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, -0.25f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.25f, -0.25f), new UnityEngine.Vector3(0.5f, 0f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, 0f, 0f), new UnityEngine.Vector3(0.5f, 0.25f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, 0.25f, 0.25f), new UnityEngine.Vector3(0.5f, 0.5f, 0.5f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                case "slopez+":
                case "fourstepstairsz+":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, -0.25f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.25f, -0.5f), new UnityEngine.Vector3(0.5f, 0f, 0.25f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, 0f, -0.5f), new UnityEngine.Vector3(0.5f, 0.25f, 0f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, 0.25f, -0.5f), new UnityEngine.Vector3(0.5f, 0.5f, -0.25f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                case "slopecornerx-":
                case "slopecorneredgex-":
                case "fourstepstairscornerx-":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, -0.25f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.25f, -0.25f, -0.25f), new UnityEngine.Vector3(0.5f, 0f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(0f, 0f, 0f), new UnityEngine.Vector3(0.5f, 0.25f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(0.25f, 0.25f, 0.25f), new UnityEngine.Vector3(0.5f, 0.5f, 0.5f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                case "slopecornerx+":
                case "slopecorneredgex+":
                case "fourstepstairscornerx+":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, -0.25f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.25f, -0.5f), new UnityEngine.Vector3(0.25f, 0f, 0.25f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, 0f, -0.5f), new UnityEngine.Vector3(0f, 0.25f, 0f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, 0.25f, -0.5f), new UnityEngine.Vector3(-0.25f, 0.5f, -0.25f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                case "slopecornerz-":
                case "slopecorneredgez-":
                case "fourstepstairscornerz-":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, -0.25f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.25f, -0.25f), new UnityEngine.Vector3(0.25f, 0f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, 0f, 0f), new UnityEngine.Vector3(0f, 0.25f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, 0.25f, 0.25f), new UnityEngine.Vector3(-0.25f, 0.5f, 0.5f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                case "slopecornerz+":
                case "slopecorneredgez+":
                case "fourstepstairscornerz+":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, -0.25f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.25f, -0.25f, -0.5f), new UnityEngine.Vector3(0.5f, 0f, 0.25f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(0f, 0f, -0.5f), new UnityEngine.Vector3(0.5f, 0.25f, 0f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(0.25f, 0.25f, -0.5f), new UnityEngine.Vector3(0.5f, 0.5f, -0.25f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                case "twostepstairsx-":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, 0f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(0f, 0f, -0.5f), new UnityEngine.Vector3(0.5f, 0.5f, 0.5f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                case "twostepstairsx+":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, 0f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, 0f, -0.5f), new UnityEngine.Vector3(0.0f, 0.5f, 0.5f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                case "twostepstairsz-":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, 0f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, 0f, 0f), new UnityEngine.Vector3(0.5f, 0.5f, 0.5f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                case "twostepstairsz+":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, 0f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, 0f, -0.5f), new UnityEngine.Vector3(0.5f, 0.5f, 0f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                case "twostepstairscornerx-":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, 0f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(0f, 0f, 0.0f), new UnityEngine.Vector3(0.5f, 0.5f, 0.5f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                case "twostepstairscornerx+":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, 0f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, 0f, -0.5f), new UnityEngine.Vector3(0f, 0.5f, 0f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                case "twostepstairscornerz-":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, 0f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, 0f, 0f), new UnityEngine.Vector3(0f, 0.5f, 0.5f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                case "twostepstairscornerz+":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, 0f, 0.5f));
                    bounds.Add(tmp);
                    tmp.SetMinMax(new UnityEngine.Vector3(0f, 0f, -0.5f), new UnityEngine.Vector3(0.5f, 0.5f, 0f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                case "twohigh":
                    tmp.SetMinMax(new UnityEngine.Vector3(-0.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, 1.5f, 0.5f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;

                default:
                    tmp.SetMinMax(new UnityEngine.Vector3(-.5f, -0.5f, -0.5f), new UnityEngine.Vector3(0.5f, 0.5f, 0.5f));
                    bounds.Add(tmp);
                    ret.collidePlayer = true;
                    break;
            }

            ret.bounds = bounds;
            return bounds;
        }
    }
}