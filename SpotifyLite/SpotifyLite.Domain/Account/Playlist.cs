﻿using SpotifyLite.Domain.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Domain.Account
{
    public class Playlist
    {
        public string Nome { get; set; }
        public IList<Musica> Musicas { get; set; }
    }
}