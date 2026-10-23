// *****************************************************************************
// @author: Yumihoshi
// @email: xiaoyuesun915@gmail.com
// @creationDate: 2026/10/23 15:10
// @version: 1.0
// @description:
// *****************************************************************************

using System;
using Models;
using UnityEngine;

namespace Controllers
{
    public class WorldController : MonoBehaviour
    {
        private World _world;

        private void Start()
        {
            _world = new World();
        }
    }
}
