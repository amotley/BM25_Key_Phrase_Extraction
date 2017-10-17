﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI
{
    public class PortugueseStopWords
    {
        public static ISet<string> GetPortugueseStopWords()
        {
            // List provided by https://gist.github.com/alopes/5358189

            ISet<string> StopWordList = new HashSet<string>();
            StopWordList.Add("a");
            StopWordList.Add("ao");
            StopWordList.Add("aos");
            StopWordList.Add("aquela");
            StopWordList.Add("aquelas");
            StopWordList.Add("aquele");
            StopWordList.Add("aqueles");
            StopWordList.Add("aquilo");
            StopWordList.Add("as");
            StopWordList.Add("até");
            StopWordList.Add("com");
            StopWordList.Add("como");
            StopWordList.Add("da");
            StopWordList.Add("das");
            StopWordList.Add("de");
            StopWordList.Add("dela");
            StopWordList.Add("delas");
            StopWordList.Add("dele");
            StopWordList.Add("deles");
            StopWordList.Add("depois");
            StopWordList.Add("do");
            StopWordList.Add("dos");
            StopWordList.Add("e");
            StopWordList.Add("ela");
            StopWordList.Add("elas");
            StopWordList.Add("ele");
            StopWordList.Add("eles");
            StopWordList.Add("em");
            StopWordList.Add("entre");
            StopWordList.Add("era");
            StopWordList.Add("eram");
            StopWordList.Add("essa");
            StopWordList.Add("essas");
            StopWordList.Add("esse");
            StopWordList.Add("esses");
            StopWordList.Add("esta");
            StopWordList.Add("estamos");
            StopWordList.Add("estas");
            StopWordList.Add("estava");
            StopWordList.Add("estavam");
            StopWordList.Add("este");
            StopWordList.Add("esteja");
            StopWordList.Add("estejam");
            StopWordList.Add("estejamos");
            StopWordList.Add("estes");
            StopWordList.Add("esteve");
            StopWordList.Add("estive");
            StopWordList.Add("estivemos");
            StopWordList.Add("estiver");
            StopWordList.Add("estivera");
            StopWordList.Add("estiveram");
            StopWordList.Add("estiverem");
            StopWordList.Add("estivermos");
            StopWordList.Add("estivesse");
            StopWordList.Add("estivessem");
            StopWordList.Add("estivéramos");
            StopWordList.Add("estivéssemos");
            StopWordList.Add("estou");
            StopWordList.Add("está");
            StopWordList.Add("estávamos");
            StopWordList.Add("estão");
            StopWordList.Add("eu");
            StopWordList.Add("foi");
            StopWordList.Add("fomos");
            StopWordList.Add("for");
            StopWordList.Add("fora");
            StopWordList.Add("foram");
            StopWordList.Add("forem");
            StopWordList.Add("formos");
            StopWordList.Add("fosse");
            StopWordList.Add("fossem");
            StopWordList.Add("fui");
            StopWordList.Add("fôramos");
            StopWordList.Add("fôssemos");
            StopWordList.Add("haja");
            StopWordList.Add("hajam");
            StopWordList.Add("hajamos");
            StopWordList.Add("havemos");
            StopWordList.Add("hei");
            StopWordList.Add("houve");
            StopWordList.Add("houvemos");
            StopWordList.Add("houver");
            StopWordList.Add("houvera");
            StopWordList.Add("houveram");
            StopWordList.Add("houverei");
            StopWordList.Add("houverem");
            StopWordList.Add("houveremos");
            StopWordList.Add("houveria");
            StopWordList.Add("houveriam");
            StopWordList.Add("houvermos");
            StopWordList.Add("houverá");
            StopWordList.Add("houverão");
            StopWordList.Add("houveríamos");
            StopWordList.Add("houvesse");
            StopWordList.Add("houvessem");
            StopWordList.Add("houvéramos");
            StopWordList.Add("houvéssemos");
            StopWordList.Add("há");
            StopWordList.Add("hão");
            StopWordList.Add("isso");
            StopWordList.Add("isto");
            StopWordList.Add("já");
            StopWordList.Add("lhe");
            StopWordList.Add("lhes");
            StopWordList.Add("mais");
            StopWordList.Add("mas");
            StopWordList.Add("me");
            StopWordList.Add("mesmo");
            StopWordList.Add("meu");
            StopWordList.Add("meus");
            StopWordList.Add("minha");
            StopWordList.Add("minhas");
            StopWordList.Add("muito");
            StopWordList.Add("na");
            StopWordList.Add("nas");
            StopWordList.Add("nem");
            StopWordList.Add("no");
            StopWordList.Add("nos");
            StopWordList.Add("nossa");
            StopWordList.Add("nossas");
            StopWordList.Add("nosso");
            StopWordList.Add("nossos");
            StopWordList.Add("num");
            StopWordList.Add("numa");
            StopWordList.Add("não");
            StopWordList.Add("nós");
            StopWordList.Add("o");
            StopWordList.Add("os");
            StopWordList.Add("ou");
            StopWordList.Add("para");
            StopWordList.Add("pela");
            StopWordList.Add("pelas");
            StopWordList.Add("pelo");
            StopWordList.Add("pelos");
            StopWordList.Add("por");
            StopWordList.Add("qual");
            StopWordList.Add("quando");
            StopWordList.Add("que");
            StopWordList.Add("quem");
            StopWordList.Add("se");
            StopWordList.Add("seja");
            StopWordList.Add("sejam");
            StopWordList.Add("sejamos");
            StopWordList.Add("sem");
            StopWordList.Add("serei");
            StopWordList.Add("seremos");
            StopWordList.Add("seria");
            StopWordList.Add("seriam");
            StopWordList.Add("será");
            StopWordList.Add("serão");
            StopWordList.Add("seríamos");
            StopWordList.Add("seu");
            StopWordList.Add("seus");
            StopWordList.Add("somos");
            StopWordList.Add("sou");
            StopWordList.Add("sua");
            StopWordList.Add("suas");
            StopWordList.Add("são");
            StopWordList.Add("só");
            StopWordList.Add("também");
            StopWordList.Add("te");
            StopWordList.Add("tem");
            StopWordList.Add("temos");
            StopWordList.Add("tenha");
            StopWordList.Add("tenham");
            StopWordList.Add("tenhamos");
            StopWordList.Add("tenho");
            StopWordList.Add("terei");
            StopWordList.Add("teremos");
            StopWordList.Add("teria");
            StopWordList.Add("teriam");
            StopWordList.Add("terá");
            StopWordList.Add("terão");
            StopWordList.Add("teríamos");
            StopWordList.Add("teu");
            StopWordList.Add("teus");
            StopWordList.Add("teve");
            StopWordList.Add("tinha");
            StopWordList.Add("tinham");
            StopWordList.Add("tive");
            StopWordList.Add("tivemos");
            StopWordList.Add("tiver");
            StopWordList.Add("tivera");
            StopWordList.Add("tiveram");
            StopWordList.Add("tiverem");
            StopWordList.Add("tivermos");
            StopWordList.Add("tivesse");
            StopWordList.Add("tivessem");
            StopWordList.Add("tivéramos");
            StopWordList.Add("tivéssemos");
            StopWordList.Add("tu");
            StopWordList.Add("tua");
            StopWordList.Add("tuas");
            StopWordList.Add("tém");
            StopWordList.Add("tínhamos");
            StopWordList.Add("um");
            StopWordList.Add("uma");
            StopWordList.Add("você");
            StopWordList.Add("vocês");
            StopWordList.Add("vos");
            StopWordList.Add("à");
            StopWordList.Add("às");
            StopWordList.Add("éramos");

            StopWordList.Add("site"); return StopWordList;
        }
    }
}
