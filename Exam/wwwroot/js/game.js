$("#UpBtn").on("click", Up)
$("#DownBtn").on("click", Down)
$("#RightBtn").on("click", Right)
$("#LeftBtn").on("click", Left)


function Down(event) {
    $.post("/Down")
        .done(function (data) {
            $(".GameField").remove();
            const element = $(".GameContainer");
            const html = element.html();
            $(".GameContainer").html(html + data);
        })
        .fail(function (data) {
            console.error("Cannot proceed [POST /StartGame]", data)
        })
}
function Up(event) {
    $.post("/Up")
        .done(function (data) {
            $(".GameField").remove();
            const element = $(".GameContainer");
            const html = element.html();
            $(".GameContainer").html(html + data);
        })
        .fail(function (data) {
            console.error("Cannot proceed [POST /StartGame]", data)
        })
}
function Right(event) {
    $.post("/Right")
        .done(function (data) {
            $(".GameField").remove();
            const element = $(".GameContainer");
            const html = element.html();
            $(".GameContainer").html(html + data);
        })
        .fail(function (data) {
            console.error("Cannot proceed [POST /StartGame]", data)
        })
}
function Left(event) {
    $.post("/Left")
        .done(function (data) {
            $(".GameField").remove();
            const element = $(".GameContainer");
            const html = element.html();
            $(".GameContainer").html(html + data);
        })
        .fail(function (data) {
            console.error("Cannot proceed [POST /StartGame]", data)
        })
}