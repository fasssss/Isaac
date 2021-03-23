﻿using System;
using UnityEngine;
using Zenject;

namespace Isaac.Bullet
{
    public class BulletFactory : IBulletFactory
    {
        private readonly DiContainer _container;
        private readonly Settings _settings;

        public BulletFactory(DiContainer container,
            Settings settings)
        {
            _container = container;
            _settings = settings;
        }

        public GameObject Create()
        {
            GameObject obj = _container.InstantiatePrefab(_settings.BulletPrefab);
            obj.SetActive(false);

            return obj;
        }
        
        [Serializable]
        public class Settings
        {
            public GameObject BulletPrefab;
        }
    }
}