function calculate()
{
    var width =parseInt(document.getElementById("width").value);
    var height =parseInt(document.getElementById("height").value);
    var area = width * height;
    document.getElementById("p1").innerHTML = area;
}