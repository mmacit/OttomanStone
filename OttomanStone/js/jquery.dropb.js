/// <reference path="jquery-1.10.2.min.js" />

var j = new jQuery.noConflict();

j.fn.extend({
    ApplyDropB: function (dr_text) {
        j(this).css("display", "none");

        var id = j(this).attr("id");

        j(this).wrap("<div id='db_" + id + "' class='dropb' ></div>");

        //<div id='dl" + rnd + "' class='dlist'></div>

        j('#db_' + id).append('<div class="drp_lbl">' + dr_text + '</div><img src="/images/btn_arrow.png" />');
        var dropb = j('#db_' + id);

        dropb.wrap("<span id='do_" + id + "'  class='dropb_out'></span>");

        var genislk = j(this).width();

        var dropb_out = j("#do_" + id);
        dropb_out.append("<div id='dl_" + id + "' class='dlist'></div>");

        // dropb.width(genislk);
        var yuks = dropb.height() / 2;

        var dropb_img = j("#db_" + id + " img");
        var di_yuks = dropb_img.height() / 2;

        yuks = yuks - di_yuks;

        dropb_img.css("margin-top", di_yuks + 3 + "px");

        var dlist = j("#dl_" + id);

        var opt_size = j("#" + id + " option").size();
        for (var i = 0; i < opt_size; i++) {
            j('#dl_' + id).append("<div class='ditem'>" + j("#" + id + " option").eq(i).text() + "</div>");

            var t_gen = parseInt(j(".ditem ").eq(i).width());
        }

        var lbl_gen = 0;
        opt_size = j("#dl_" + id + " .ditem ").size();
        for (var i = 0; i < opt_size; i++) {
            var t_gen = parseInt(j("#dl_" + id + " .ditem ").eq(i).outerWidth());
            if (parseInt(lbl_gen) < t_gen) {
                lbl_gen = j("#dl_" + id + " .ditem ").eq(i).innerWidth();
            }
        }

        dropb.click(function () {
            var tid = "dl_" + j(this).attr("id").split("_")[1];
            j("#" + tid).show();
        });

        var tiddl = j(this).attr("id");
        j("#dl_" + tiddl).mouseleave(function () {
            j(this).hide();
        });

        j("#dl_" + tiddl + " .ditem").click(function () {
            var yazi = j(this).html();
            j('#do_' + id + ' #db_' + id + ' .drp_lbl').html(yazi);
            j('#dl_' + tiddl).hide();
        });
    }
});