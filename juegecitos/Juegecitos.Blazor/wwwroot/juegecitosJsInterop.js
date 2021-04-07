function Juegecitos() {
    function loop(timeStamp)
    {
        window.requestAnimationFrame(loop);
        window.juegecitos.instance.invokeMethod('Loop', timeStamp);
    }
    this.instance = undefined;
    this.init = function (instance) {
        this.instance = instance;
        window.requestAnimationFrame(loop);
    }
}

window.juegecitos = new Juegecitos();