
<script>
        window.onload=function(){
            var btn=document.getElementById("btn");
            btn.onclick=function(){
                var ts=document.getElementById("ts").value;
                var dn=document.getElementsByClassName("dn");
                for(var i=0;i<ts;i++){
                    var input=document.createElement("input");
                    input.setAttribute("class","text");
                    input.type="text";
                    input.name="字符";
                    input.id="inp";
                    dn[0].appendChild(input);
 
                }
                var button=document.createElement("input");
                button.setAttribute("class","but");
                button.type="button";
                button.name="anniu";
                button.value="确认";
                button.id="but";
                dn[0].appendChild(button);
 
                var pics=document.getElementById("dnn").getElementsByTagName("input");
                var len=pics.length;
                var but=document.getElementById("but");
                but.onclick=function(){ 
                    for(var j=0;j<len;j++){
                        var inp=document.getElementById("inp").value; 
                        console.log(inp);
                    }
                    console.log(inp);
                }
            }
        }
    </script>
