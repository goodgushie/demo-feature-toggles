Calculators = (function() {
    function init() {
        $(".button__operation").on("click",
            function(e) {
                e.preventDefault();
                var btn = $(this);
                var operation = btn.data("operation");
                var valueA = Number($("#" + btn.data("input-a")).val());
                var valueB = Number($("#" + btn.data("input-b")).val());
                if (isNaN(valueB)) valueB = 3;
                switch (operation) {
                case "plus":
                    alert(valueA + valueB);
                    break;
                case "minus":
                    alert(valueA - valueB);
                    break;
                case "multiply":
                    alert(valueA * valueB);
                    break;
                case "divide":
                    alert(valueA / valueB);
                    break;
                case "modulo":
                    $.get("/features/featureisenabled?id=1")
                        .done(function(data) {
                            if (data === "True") {
                                $.get("/calculators/moduloresult?a=" + valueA + "&b=" + valueB)
                                    .done(function(result) { alert(result); });
                            } else alert("Unknown operation");
                        });
                    break;
                default:
                    alert("Unknown operation");
                }
            });

        $(".button__random").on("click",
            function(e) {
                e.preventDefault();
                $.get("/calculators/randomnumber?max=" + $("#inputMax").val())
                    .done(function(data) {
                        alert(data);
                    });
            });
    }

    init();

    return {
        "init": init
    };
})();