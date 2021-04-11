function Juegecitos() {
    function loop(timeStamp) {
        window.requestAnimationFrame(loop);
        window.juegecitos.instance.invokeMethod('Loop', timeStamp);
    }
    this.instance = undefined;
    this.canvas = undefined;
    this.context2d = undefined;
    this.init = function (instance, canvas) {
        this.instance = instance;
        this.canvas = canvas;
        canvas.tabIndex = 0;
        canvas.focus();
        window.requestAnimationFrame(loop);
    }
    this.setContext = function (type) {
        var context = this.canvas.getContext(type);

        if (type == '2d')
            this.context2d = context;
    }
    this.clearRect = function (x, y, width, height) {
        this.context2d.clearRect(x, y, width, height);
    }
    this.setfillStyle = function (_style) {
        var style = BINDING.conv_string(_style);

        this.context2d.fillStyle = style;
    }
    this.fillRect = function (x, y, width, height) {
        this.context2d.fillRect(x, y, width, height);
    }
    this.setfont = function (_font) {
        var font = BINDING.conv_string(_font);

        this.context2d.font = font;
    }
    this.strokeText = function (_text, x, y) {
        var text = BINDING.conv_string(_text);

        this.context2d.strokeText(text, x, y);
    }
    this.fillText = function (_text, x, y) {
        var text = BINDING.conv_string(_text);

        this.context2d.fillText(text, x, y);
    }
}

window.juegecitos = new Juegecitos();