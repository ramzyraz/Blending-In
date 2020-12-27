using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LayerMaskExtensions
{
     public static int[] HasLayers(this LayerMask layerMask)
     {
         int[] mylayers = new int[3];
         int j = 0;
 
         for (int i = 0; i < 32; i++)
         {
             if (layerMask == (layerMask | (1 << i)))
             {
                mylayers[j] = i;
                j += 1;
             }
         }
 
         return mylayers;
     }
}
