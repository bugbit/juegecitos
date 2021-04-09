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
        window.requestAnimationFrame(loop);
    }
    this.setContext=function(type)
    {
        var context = this.canvas.getContext(type);

        if (type == '2d')
            this.context2d = context;
    }
    this.clearRect = function (x, y, width, height) {
        this.context2d.clearRect(x, y, width, height);
    }
}

window.juegecitos = new Juegecitos();