﻿namespace Treasure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Chest
    {
        private int key;
        private IList<int> keys;
        private bool opened;

        public Chest(int key, IList<int> keys)
        {
            this.key = key;
            this.keys = keys;
        }

        public int Key { get { return this.key; } }

        public bool Opened { get { return this.opened; } }

        public IEnumerable<int> Keys { get { return this.keys; } }

        public void Open()
        {
            this.opened = true;
        }

        public void Close()
        {
            this.opened = false;
        }
    }
}