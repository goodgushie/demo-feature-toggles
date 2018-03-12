Features = (function() {
    function init() {
        $(".button__toggle").on("click", function (e) {
            e.preventDefault();
            var btn = $(this);
            $.get("/features/togglefeature?id=" + btn.data("id"),
                function() {
                    $(".span__features").load("/features/featureslist",
                        function() {
                            Features.init();
                        });
                });
        });
    }

    init();

    return {
        "init": init
    };
})();