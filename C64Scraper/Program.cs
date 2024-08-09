using C64Scraper;

var sources = new List<string>
{
    "https://www.c64.com/games/no-frame.php?searchfor_special=1&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=a&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=b&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=c&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=d&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=e&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=f&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=g&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=h&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=i&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=j&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=k&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=l&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=m&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=n&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=o&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=p&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=q&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=r&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=s&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=t&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=u&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=v&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=w&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=x&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=y&show_review=&showid=2485&from=0&range=10000",
    "https://www.c64.com/games/no-frame.php?searchfor_special=z&show_review=&showid=2485&from=0&range=10000"
};

var games = new List<Game>();

var parser = new GameListParser(@"<html>

<head>

<title>C64.COM - For the best in C64 nostalgia</title>

<meta name=""robots"" content=""index,nofollow"">

<link rel=""stylesheet"" href=""format.css"" type=""text/css"">

<SCRIPT LANGUAGE=""JavaScript"">

NewImg = new Array

(


""screenshots/a/aaargh_condor_games_machine_01.gif""

,
	
""screenshots/a/aaargh_condor_games_machine_02.gif""

,
	
""screenshots/a/aaargh_condor_games_machine_03.gif""

,
	
""screenshots/a/aaargh_condor_games_machine_04.gif""

,
	
""screenshots/a/aaargh_condor_games_machine_05.gif""

,
	
""screenshots/a/aaargh_condor_games_machine_06.gif""

,
	
""screenshots/a/aaargh_condor_games_machine_07.gif""

,
	
""screenshots/a/aaargh_condor_games_machine_08.gif""

,
	
""screenshots/a/aaargh_condor_games_machine_09.gif""

,
	
""screenshots/a/aaargh_condor_games_machine_10.gif""


	
);



b = new Array();



for(i=0;i<NewImg.length;i++)

{

    b[i] = new Image();

	b[i].src = NewImg[i];

}



var ImgNum = 0;

var ImgLength = NewImg.length - 1;



//Time delay between Slides in milliseconds

var delay = 3000;



var lock = false;

var run;

function chgImg(direction)

{

	if (document.images)

	{

		ImgNum = ImgNum + direction;

		if (ImgNum > ImgLength)

		{

			ImgNum = 0;

		}

		if (ImgNum < 0)

		{

			ImgNum = ImgLength;

		}

		document.slideshow.src = b[ImgNum].src;

   }

}



function auto() {

if (lock == true) {

lock = false;

window.clearInterval(run);

}

else if (lock == false) {

lock = true;

run = setInterval(""chgImg(1)"", delay);

   }

}



</script>



<script language=""JavaScript"">

<!--

var exwin=null;

function showInlay(theURL,winName,features, myWidth, myHeight, isCenter) { //v3.0

  winName=""c64hqinlay"";

  if(window.screen)if(isCenter)if(isCenter==""true""){

    var myLeft = (screen.width-myWidth)/2;

    var myTop = (screen.height-myHeight)/2;

    features+=(features!='')?',':'';

    features+=',left='+myLeft+',top='+myTop;

  }

  if(exwin!=null)exwin.close();

  window.open(theURL,winName,features+((features!='')?',':'')+'width='+myWidth+',height='+myHeight);

}



//-->

</script>



</head>



<body leftmargin=""0"" topmargin=""0"" marginwidth=""0"" marginheight=""0"">

<table border=""0"" cellspacing=""0"" cellpadding=""0"">

  <tr> 

    <td width=""320"" valign=""top""> 

      <table border=""0"" cellspacing=""0"" cellpadding=""0"">

        <tr> 

          <td><img src=""images/games2.gif"" width=""331"" height=""26"" border=""0""></td>

        </tr>

        <tr> 

          <td bgcolor=""#676767"" valign=""top""> 

                <table border=""0"" cellspacing=""0"" cellpadding=""0"">
              <tr> 
                           <table border=""0"" cellspacing=""0"" cellpadding=""0"">
              <tr> 
                <td bgcolor=""#000000""><img src=""images/empty.gif"" width=""1"" height=""2""></td>
                <td bgcolor=""#A1A1A1""><img src=""images/empty.gif"" width=""1"" height=""2""></td>
                <td bgcolor=""#8D8D8D""><img src=""images/empty.gif"" width=""3"" height=""2""></td>
                <td bgcolor=""#000000""><img src=""images/empty.gif"" width=""1"" height=""2""></td>
                <td width=""320""> 
      <table width=""320"" border=""0"" cellspacing=""0"" cellpadding=""0"">
        <tr valign=""top""> 
          <td height=""210""><img src=""screenshots/a/aaargh_condor_games_machine_01.gif"" name=""slideshow"" width=""320"" height=""200"" border=""0""><br>
            <table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">
			              <tr align=""center"" valign=""top"">
                <td colspan=""2""><img src=""images/streck_game.gif"" width=""320"" height=""1""></td>
              </tr>
              <tr align=""center"" valign=""middle"" bgcolor=""#535353"">
                <td height=""41"" colspan=""2""><span class=""headline_1"">Aaargh! Condor</span><br>
&copy; <a onFocus=""this.blur()"" href=""no-frame.php?searchtype=1&searchfor=1983&show_review=&showid=2485""><span class=""headline_2""> 1983</span></a> 
            <a onFocus=""this.blur()"" href=""no-frame.php?searchtype=1&searchfor=Games+Machine&show_review=&showid=2485""><span class=""headline_2"">Games Machine</span></a></td>
              </tr>
              <tr>
                <td valign=""top"" align=""left""></td>
                <td valign=""top"" align=""right""></td>
              </tr>
              <tr align=""center"" valign=""top"">
                <td colspan=""2""><img src=""images/streck_game.gif"" width=""320"" height=""1""></td>
              </tr>
              <tr align=""center"" valign=""middle"">
                <td height=""20"" colspan=""2"" class=""headline_1""><b><a onFocus=""this.blur()"" href=""javascript:chgImg(-1)"">&laquo;</a> </b><a onFocus=""this.blur()"" href=""javascript:auto()"">play/stop</a><b> <a onFocus=""this.blur()"" href=""javascript:chgImg(1)"">&raquo;</a></b></td></tr>
              <tr align=""center"">
                <td colspan=""2"" valign=""top""><img src=""images/streck_game.gif"" width=""320"" height=""1""></td>
              </tr>
            </table></td>
        </tr>
        <tr valign=""top""> 
          <td> 
            <table width=""302"" border=""0"" cellspacing=""0"" cellpadding=""0"" align=""center"">
              <tr valign=""top""> 
                <td> 
                  <table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">


                  </table>
                  <br>
                  <table width=""260"" border=""0"" cellspacing=""0"" cellpadding=""0"" align=""center"">
                    <tr>
                      <td valign=""top"" align=""left"">
                        By:
                      </td>
                      <td valign=""top"" align=""right"">
                        <a onFocus=""this.blur()"" href=""no-frame.php?searchtype=1&searchfor=Alan+G.+Osborne"">Alan G. Osborne</a>
                      </td>
                    </tr>
                    <tr>
                        <td valign=""top"" align=""left"">
                        Genre:
                        </td>
                        <td valign=""top"" align=""right"">
                        <a onFocus=""this.blur()"" href=""no-frame.php?searchfor=1&searchfor_special=4"">Action</a>
                        </td>
                    </tr>
                    <tr>
                        <td colspan=""2""><br></td>
                    </tr>
        <tr>
        <td valign=""top"" align=""left"">
        Inlay scan:
        </td>
        <td valign=""top"" align=""right""> 
        <a onFocus=""this.blur()"" href=""javascript:showInlay('inlay.php?url=inlays/a/aaargh_condor.png','Aaargh!Condor','','558','900','true')"">Display</a>
        </td>
    </tr>
        <tr>
        <td valign=""top"" align=""left"">
        Rating:
        </td>
        <td valign=""top"" align=""right"">
        <a onFocus=""this.blur()"" href=""/games/no-frame.php?showid=2485&show_rate=1&searchfor_special=a&searchfor=&from=0&range=10000"">Rate</a><br>
        </td>
    </tr>
    <tr>
        <td valign=""top"" align=""left"">
        Download:
        </td>
        <td valign=""top"" align=""right"">
                <a onFocus=""this.blur()"" href=""download.php?id=2485"">Game</a>
        </td>
    </tr>
    
                      </td>
                    </tr>    
                    <tr> 
                      <td valign=""top"" align=""left"" colspan=""2"">
												<br>
                        Direct link: <a onFocus=""this.blur()"" href=""http://www.c64.com/games/2485"" target=""_top"">www.c64.com/games/2485</a>.<br><br>
                                                <iframe src=""//www.facebook.com/plugins/like.php?href=http://www.c64.com/games/2485&amp;send=false&amp;layout=button_count&amp;width=250&amp;show_faces=false&amp;action=like&amp;colorscheme=dark&amp;font=verdana&amp;height=21"" scrolling=""no"" frameborder=""0"" style=""border:none; overflow:hidden; width:250px; height:21px;"" allowTransparency=""true""></iframe><br><br>                      </td>
                    </tr>
                  </table>
                </td>
              </tr>
            </table>
          </td>
        </tr>
      </table>
                      </td>
                <td bgcolor=""#A1A1A1""><img src=""images/empty.gif"" width=""1"" height=""2""></td>
                <td bgcolor=""#8E8E8E""><img src=""images/empty.gif"" width=""2"" height=""2""></td>
                <td bgcolor=""#6A6A6A""><img src=""images/empty.gif"" width=""1"" height=""2""></td>
                <td bgcolor=""#000000""><img src=""images/empty.gif"" width=""1"" height=""2""></td>
              </tr>
            </table>


          </td>

        </tr>

        <tr> 

          <td><img src=""images/titlescreens2.gif"" width=""331"" height=""11""></td>

        </tr>

      </table>

    </td>

    <td><img src=""images/empty.gif"" width=""6"" height=""6""></td>

    <td valign=""top"" width=""250"">

      <table width=""134"" border=""0"" cellspacing=""0"" cellpadding=""0"">

        <tr> 

          <td><img src=""images/searchresult.gif"" width=""262"" height=""26""></td>

        </tr>

        <tr> 

          <td bgcolor=""#B55826"" valign=""top""> 

                  <table border=""0"" cellspacing=""0"" cellpadding=""0"">
              <tr> 
                <td bgcolor=""#000000""><img src=""images/empty.gif"" width=""1"" height=""2""></td>
                <td bgcolor=""#E69265""><img src=""images/empty.gif"" width=""1"" height=""2""></td>
                <td bgcolor=""#E27C45""><img src=""images/empty.gif"" width=""3"" height=""2""></td>
                <td bgcolor=""#000000""><img src=""images/empty.gif"" width=""1"" height=""2""></td>
                <td width=""190"" valign=""top""> 
                  <table width=""100%"" border=""0"" cellspacing=""5"" cellpadding=""0"">
                    <tr> 
                      <td> 
                        <table border=""0"" cellspacing=""0"" cellpadding=""0"" width=""240"">
                          <tr> 
                            <td valign=""top""> 
                              <table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                          <tr> 
                            <td width=""80"" valign=""middle""><a onFocus=""this.blur()"" href=""no-frame.php?showid=2485&searchfor=&searchfor_special=a&from=0&range=10000""><img src=""screenshots/a/aaargh_condor_games_machine_01.gif"" width=""80"" height=""50"" border=""0""></a></td>
                            <td valign=""top"" width=""5"">&nbsp;</td>
                            <td valign=""top"" width=""160""><a  onFocus=""this.blur()"" href=""no-frame.php?showid=2485&searchfor=&searchfor_special=a&from=0&range=10000""><b>Aaargh! Condor</b></a>
                            <br>Games Machine 1983<br>
                              2815 downloads<br>
                              <a onFocus=""this.blur()"" href=""download.php?id=2485"">Download 
                              now</a></td>
                          </tr>
                          <tr> 
                            <td colspan=""3"" valign=""middle""> <img src=""images/streck_games.gif"" width=""241"" height=""11""></td>
                          </tr>
 
			                          <tr> 
                            <td width=""80"" valign=""middle""><a onFocus=""this.blur()"" href=""no-frame.php?showid=1495&searchfor=&searchfor_special=a&from=0&range=10000""><img src=""screenshots/a/abc_01.gif"" width=""80"" height=""50"" border=""0""></a></td>
                            <td valign=""top"" width=""5"">&nbsp;</td>
                            <td valign=""top"" width=""160""><a  onFocus=""this.blur()"" href=""no-frame.php?showid=1495&searchfor=&searchfor_special=a&from=0&range=10000""><b>ABC</b></a>
                            <br>Digital Developments 1988<br>
                              8798 downloads<br>
                              <a onFocus=""this.blur()"" href=""download.php?id=1495"">Download 
                              now</a></td>
                          </tr>
                          <tr> 
                            <td colspan=""3"" valign=""middle""> <img src=""images/streck_games.gif"" width=""241"" height=""11""></td>
                          </tr>
 
			                          <tr> 
                            <td width=""80"" valign=""middle""><a onFocus=""this.blur()"" href=""no-frame.php?showid=71&searchfor=&searchfor_special=a&from=0&range=10000""><img src=""screenshots/a/abc_monday_night_football_01.gif"" width=""80"" height=""50"" border=""0""></a></td>
                            <td valign=""top"" width=""5"">&nbsp;</td>
                            <td valign=""top"" width=""160""><a  onFocus=""this.blur()"" href=""no-frame.php?showid=71&searchfor=&searchfor_special=a&from=0&range=10000""><b>ABC Monday Night Football</b></a>
                            <br>Data East 19??<br>
                              7514 downloads<br>
                              <a onFocus=""this.blur()"" href=""download.php?id=71"">Download 
                              now</a></td>
                          </tr>
                          <tr> 
                            <td colspan=""3"" valign=""middle""> <img src=""images/streck_games.gif"" width=""241"" height=""11""></td>
                          </tr>
 
			                          <tr> 
                            <td width=""80"" valign=""middle""><a onFocus=""this.blur()"" href=""no-frame.php?showid=43&searchfor=&searchfor_special=a&from=0&range=10000""><img src=""screenshots/a/ace_2_01.gif"" width=""80"" height=""50"" border=""0""></a></td>
                            <td valign=""top"" width=""5"">&nbsp;</td>
                            <td valign=""top"" width=""160""><a  onFocus=""this.blur()"" href=""no-frame.php?showid=43&searchfor=&searchfor_special=a&from=0&range=10000""><b>Ace 2</b></a>
                            <br>Cascade Games 1987<br>
                              19510 downloads<br>
                              <a onFocus=""this.blur()"" href=""download.php?id=43"">Download 
                              now</a></td>
                          </tr>
                          <tr> 
                            <td colspan=""3"" valign=""middle""> <img src=""images/streck_games.gif"" width=""241"" height=""11""></td>
                          </tr>
 
			                          <tr> 
                            <td width=""80"" valign=""middle""><a onFocus=""this.blur()"" href=""no-frame.php?showid=1496&searchfor=&searchfor_special=a&from=0&range=10000""><img src=""screenshots/a/ace_2088_01.gif"" width=""80"" height=""50"" border=""0""></a></td>
                            <td valign=""top"" width=""5"">&nbsp;</td>
                            <td valign=""top"" width=""160""><a  onFocus=""this.blur()"" href=""no-frame.php?showid=1496&searchfor=&searchfor_special=a&from=0&range=10000""><b>Ace 2088</b></a>
                            <br>Cascade Games 1988<br>
                              10065 downloads<br>
                              <a onFocus=""this.blur()"" href=""download.php?id=1496"">Download 
                              now</a></td>
                          </tr>
                          <tr> 
                            <td colspan=""3"" valign=""middle""> <img src=""images/streck_games.gif"" width=""241"" height=""11""></td>
                          </tr>
 
			                        </table>
                        <table border=""0"" cellspacing=""0"" cellpadding=""0"">
                          <tr> 
                            <td><br><font face=""Verdana"" size=""-2"">
<a  onFocus=""this.blur()"" href=""games.php"">First page</a>
                            </font>
                            </td>
                          </tr>
                          <tr> 
                            <td><br><img src=""images/streck_games.gif"" width=""241"" height=""11""></td>
                          </tr>
                          <tr> 
                            <td valign=""top"">
                              <form name=""form"" method=""post"" action=""/games/no-frame.php"">
                                <input type=""hidden"" name=""lastfound"" value=""2485"">
                          <table border=""0"" cellspacing=""0"" cellpadding=""0"" align=""left"">
                            <tr valign=""middle"" align=""left""> 
                              <td width=""132""> 
                                <input class=noformborder name=searchfor size=""23"">
                              </td> 
<td> 
<input border=0 cache height=18 name=imageField src=""../images/seekbutton.gif""
type=image width=44><input type=""hidden"" name=""searchtype"" value=""0"">
</td> 
</tr> 
</table></form></td>
                                </tr>
                              </table>
                            </td>
                          </tr>
                        </table>
                      </td>
                    </tr>
                  </table>
                </td>
                <td bgcolor=""#E69265""><img src=""images/empty.gif"" width=""1"" height=""2""></td>
                <td bgcolor=""#E27C45""><img src=""images/empty.gif"" width=""2"" height=""2""></td>
                <td bgcolor=""#BB5A27""><img src=""images/empty.gif"" width=""1"" height=""2""></td>
                <td bgcolor=""#000000""><img src=""images/empty.gif"" width=""1"" height=""2""></td>
              </tr>
            </table>
          </td>

        </tr>

        <tr>

          <td><img src=""images/searchresult2.gif"" width=""262"" height=""11""></td>

        </tr>

      </table>

    </td>

  </tr>

</table>

<br>

</body>

</html>");

games.AddRange(parser.Parse());
