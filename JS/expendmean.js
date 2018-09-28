$(document).ready(function () {
    //页面完成dom装载时，执行此代码
    //一级菜单：找到类 main 的子节点 a，并添加单击事件
    $(".main a").click(function () {

        //更换三角指示图标
        var pictur = $(this);
        changeIcon(pictur);
        //找到main 下面的a  的下面的ui 
        var secondNode = $(this).next("ul");
        //判断该ui事件的css 属性
        if (secondNode.css("display") == "none") {
            secondNode.css("display", "block");
        } else { secondNode.css("display", "none"); }
    });
    //找到二级菜单，并设置单击事件
    $(".main li a").click(function () {

        alert("该菜单没有下一步事件");
    });
});
//定义函数：更改三角指示图标函数
function changeIcon(mainNode) {
    if (mainNode) {
        //如果该节点的背景的图片里面包含collapsed.gif,就把它改成另一个，如果不包含就改回来。
        if (mainNode.css("background-image").indexOf("collapsed.gif") >= 0) {
            mainNode.css("background-image", "url('../Images/expanded.gif')");
        } else {
            mainNode.css("background-image", "url('../Images/collapsed.gif')");
        }
    }
}
