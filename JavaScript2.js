﻿<!DOCTYPE html>
<html>
<body>

<p>
JavaScript 能够直接写入 HTML 输出流中：
</p>

<script>
document.write("<h1>This is a heading</h1>");
document.write("<p>This is a paragraph.</p>");
</script>

<p>
您只能在 HTML 输出流中使用 <strong>document.write</strong>。
如果您在文档已加载后使用它（比如在函数中），会覆盖整个文档。
</p>

</body>
</html>
