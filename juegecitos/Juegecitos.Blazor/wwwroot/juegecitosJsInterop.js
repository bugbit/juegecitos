function Juegecitos() {
    function loop(timeStamp) {
        window.requestAnimationFrame(loop);
        window.juegecitos.instance.invokeMethod('Loop', timeStamp);
    }
    function insertAsset(as, arr) {
        var i;

        if (arr.unload.length > 0) {
            i = arr.unload.pop();
            arr.load[i] = as;
        }
        else
            i = arr.load.push(as) - 1;

        return i;
    }
    function getAsset(i, arr) {
        if (i < 0 || i > arr.load.length)
            return undefined;

        return arr.load[i];
    }
    function destroyAsset(i, arr) {
        if (i < 0 || i > arr.load.length)
            return false;

        arr.load[i] = undefined;
        arr.unload.push(i);

        return true;
    }
    this.instance = undefined;
    this.main = undefined;
    this.canvas = undefined;
    this.context2d = undefined;
    this.assets =
    {
        sounds:
        {
            load: [],
            unload: []
        }
    }
    this.init = function (instance, main, canvas) {
        this.instance = instance;
        this.main = main;
        this.canvas = canvas;
        canvas.tabIndex = 0;
        canvas.focus();
        window.requestAnimationFrame(loop);
    }
    this.changeGame = function (g) {
        const backcolor = Blazor.platform.readStringField(g, 0);
        const width = Blazor.platform.readInt32Field(g, 0 + 8);
        const height = Blazor.platform.readInt32Field(g, 0 + 8 + 4);
        const context = Blazor.platform.readStringField(g, 0 + 8 + 4 + 4);

        this.main.style.backgroundColor = this.canvas.backgroundColor = backcolor;
        this.canvas.width = width;
        this.canvas.height = height;
        this.setContext(context);
        this.canvas.tabIndex = 0;
        this.canvas.focus();
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
    this.setTransform = function (a, b, c, d, e, f) {
        this.context2d.setTransform(a, b, c, d, e, f);
    }
    this.beginPath = function () {
        this.context2d.beginPath();
    }
    this.closePath = function () {
        this.context2d.closePath();
    }
    this.arc = function (x, y, radius, startAngle, endAngle, counterclockwise) {
        this.context2d.arc(x, y, radius, startAngle, endAngle, counterclockwise);
    }
    this.fill = function () {
        this.context2d.fill();
    }
    this.loadSound = function (_url) {
        var url = BINDING.conv_string(_url);
        var as = new Audio("assets/" + url);

        insertAsset(as, this.assets.sounds)
    }
    this.unloadSound = function (i) {
        var as = getAsset(i, this.assets.sounds);

        if (as)
            as.pause();

        return destroyAsset(i, this.assets.sounds);
    }
    this.playSound = function (i) {
        var as = getAsset(i, this.assets.sounds);

        if (!as)
            return false;

        as.play();

        return true;
    }
}

window.juegecitos = new Juegecitos();

