
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
namespace ZYFGameObjectBrush
{
    /// <summary>
    /// GameObject扩展方法
    /// </summary>
    public static class ZYF_GameObject_Extension
    {
      
        public static void DestroyGo(this GameObject go, float delay = -1)
        {
            if (go == null)
            {
                return;
            }
#if UNITY_EDITOR
            if (Application.isPlaying == false)
            {
                var res = UnityEditor.PrefabUtility.GetNearestPrefabInstanceRoot(go);
                if (res != null)
                {
                    go = res;
                }
            }
#endif
            if (Application.isPlaying)
            {
               GameObject. Destroy(go,delay);
            }
            else
            {
                GameObject.DestroyImmediate(go);
            }
        }
        
    }

}
