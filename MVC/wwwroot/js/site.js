function getLayerProps() {
    var props = {};
    props["transparent"] = true;
    //props["disableCache"] = false;
    //props["useCors"] = true;

    return props;
}
function getUniqueIDrun() {
    var date = new Date();
    var str = pad(date.getFullYear(), 4) + pad(date.getMonth() + 1, 2) + pad(date.getDate(), 2) + pad(date.getHours(), 2) + pad(date.getMinutes(), 2) + pad(date.getSeconds(), 2);
    return str;
}

function pad(n, width, z) {
    z = z || '0';
    n = n + '';
    return n.length >= width ? n : new Array(width - n.length + 1).join(z) + n;
}

$(document).ready(function () {
   /* setInterval(function () {
        $.post("/home/home/getStatus/", function (data) {
            if (data["result"] == "1") {
                $('#connectionLost').hide();
            } else {
                $('#connectionLost').show();
                $('#connectionLost').html("<div class='alert-icon'> <i class='fa fa-exclamation-triangle'></i></div> <div class='alert-text'> Connection has beel lost - Saving data in local storage</div> <div class='alert-close'><button type='button' class='close' data-dismiss='alert' style='font-size: 14px;'><i class='la la-close'></i></button></div>");
            }
        }, 'json').fail(function () {
            $('#connectionLost').show();
            $('#connectionLost').html("<div class='alert-icon'> <i class='fa fa-exclamation-triangle'></i></div> <div class='alert-text'> Connection has beel lost - Saving data in local storage </div> <div class='alert-close'><button type='button' class='close' data-dismiss='alert' style='font-size: 14px;'><i class='la la-closee'></i></button></div>");
        });
    }, 3000);*/

    (function ($) {

        $.extend({

            APP: {

                formatTimer: function (a) {
                    if (a < 10) {
                        a = '0' + a;
                    }
                    return a;
                },

                startTimer: function (dir) {
                    var a;
                    // save type
                    $.APP.dir = dir;
                    // get current date
                    $.APP.d1 = new Date();
                    switch ($.APP.state) {
                        case 'pause':
                            // resume timer
                            // get current timestamp (for calculations) and
                            // substract time difference between pause and now
                            $.APP.t1 = $.APP.d1.getTime() - $.APP.td;
                            break;
                        default:
                            // get current timestamp (for calculations)
                            $.APP.t1 = $.APP.d1.getTime();
                            // if countdown add ms based on seconds in textfield
                            if ($.APP.dir === 'cd') {
                                $.APP.t1 += parseInt($('#cd_seconds').val()) * 1000;
                            }
                            break;
                    }
                    // reset state
                    $.APP.state = 'alive';
                    $('#' + $.APP.dir + '_status').html('Running');
                    // start loop
                    $.APP.loopTimer();
                },
                pauseTimer: function () {
                    // save timestamp of pause
                    $.APP.dp = new Date();
                    $.APP.tp = $.APP.dp.getTime();
                    // save elapsed time (until pause)
                    $.APP.td = $.APP.tp - $.APP.t1;
                    // change button value
                    $('#' + $.APP.dir + '_start').val('Resume');
                    // set state
                    $.APP.state = 'pause';
                    $('#' + $.APP.dir + '_status').html('Paused');
                },
                stopTimer: function () {
                    // change button value
                    $('#' + $.APP.dir + '_start').val('Restart');
                    // set state
                    $.APP.state = 'stop';
                    $('#' + $.APP.dir + '_status').html('Stopped');
                },
                resetTimer: function () {
                    // reset display
                    $('#' + $.APP.dir + '_ms,#' + $.APP.dir + '_s,#' + $.APP.dir + '_m,#' + $.APP.dir + '_h').html('00');
                    // change button value
                    $('#' + $.APP.dir + '_start').val('Start');
                    // set state
                    $.APP.state = 'reset';
                    $('#' + $.APP.dir + '_status').html('Reset & Idle again');
                },
                endTimer: function (callback) {
                    // change button value
                    $('#' + $.APP.dir + '_start').val('Restart');
                    // set state
                    $.APP.state = 'end';
                    // invoke callback
                    if (typeof callback === 'function') {
                        callback();
                    }
                },
                loopTimer: function () {
                    var td;
                    var d2, t2;
                    var ms = 0;
                    var s = 0;
                    var m = 0;
                    var h = 0;
                    if ($.APP.state === 'alive') {
                        // get current date and convert it into 
                        // timestamp for calculations
                        d2 = new Date();
                        t2 = d2.getTime();
                        // calculate time difference between
                        // initial and current timestamp
                        if ($.APP.dir === 'sw') {
                            td = t2 - $.APP.t1;
                            // reversed if countdown
                        } else {
                            td = $.APP.t1 - t2;
                            if (td <= 0) {
                                // if time difference is 0 end countdown
                                $.APP.endTimer(function () {
                                    $.APP.resetTimer();
                                    $('#' + $.APP.dir + '_status').html('Ended & Reset');
                                });
                            }
                        }
                        // calculate milliseconds
                        ms = td % 1000;
                        if (ms < 1) {
                            ms = 0;
                        } else {
                            // calculate seconds
                            s = (td - ms) / 1000;
                            if (s < 1) {
                                s = 0;
                            } else {
                                // calculate minutes   
                                var m = (s - (s % 60)) / 60;
                                if (m < 1) {
                                    m = 0;
                                } else {
                                    // calculate hours
                                    var h = (m - (m % 60)) / 60;
                                    if (h < 1) {
                                        h = 0;
                                    }
                                }
                            }
                        }
                        // substract elapsed minutes & hours
                        ms = Math.round(ms / 100);
                        s = s - (m * 60);
                        m = m - (h * 60);
                        // update display
                        $('#' + $.APP.dir + '_ms').html($.APP.formatTimer(ms));
                        $('#' + $.APP.dir + '_s').html($.APP.formatTimer(s));
                        $('#' + $.APP.dir + '_m').html($.APP.formatTimer(m));
                        $('#' + $.APP.dir + '_h').html($.APP.formatTimer(h));
                        // loop
                        $.APP.t = setTimeout($.APP.loopTimer, 100);
                    } else {
                        // kill loop
                        clearTimeout($.APP.t);
                        return true;
                    }
                }
            }
        });
    })(jQuery);
});

/********************* GENERIC FUNCTIONS ******************************/

function show_wait() {
    swal.fire({
        title: 'Please wait',
        html: 'Please do not navigate away from this page.<br /><div class="timer_wait"><span id="sw_h">00</span>:<span id="sw_m">00</span>:<span id="sw_s">00</span></div>',
        imageUrl: '/images/loader_200.gif',
        imageWidth: 200,
        imageHeight: 200,
        showConfirmButton: false,
        allowEscapeKey: false,
        allowOutsideClick: false,
        onOpen: function () {
            if ($.APP)
                $.APP.startTimer('sw');
            else
                $(".timer_wait").hide();
        }
    });
}

function showMsg(title, msg){
    swal.fire({
        type: title,
        title: title,
        html: msg,
        showConfirmButton: true
    });
}


function getFormConsent(form_elem) {
    var html = "";
    html += '<div class="row">';
    html += '<div class="col-12">';
    html += "<table>";
    form_elem.find(".form-group").each(function () {
        $(this).find("input, select, textarea").each(function () {
            if ($(this).is("input") || $(this).is("select") || $(this).is("textarea") || $(this).is(":checkbox")) {

                if ($(this).is(":checkbox") && !$(this).is(':checked')) return;

                html += "<tr>";
                html += "<td>";

                var label;
                var attr_elem;

                attr_elem = $(this).attr('id');
                if (typeof attr_elem !== typeof undefined && attr_elem !== false) {
                    label = $('label').filter(function () {
                        var attr = $(this).attr('for');
                        if (typeof attr !== typeof undefined && attr !== false && attr.toString().toLowerCase().indexOf(attr_elem.toLowerCase()) > -1)
                            return true;
                        return false;
                    });
                }

                if (typeof label === typeof undefined) {
                    attr_elem = $(this).attr('name');
                    if (typeof attr_elem !== typeof undefined && attr_elem !== false) {
                        label = $('label').filter(function () {
                            var attr = $(this).attr('for');
                            if (typeof attr !== typeof undefined && attr !== false && attr.toString().toLowerCase().indexOf(attr_elem.toLowerCase()) > -1)
                                return true;
                            return false;
                        });
                    }
                }


                if (typeof label !== typeof undefined)
                    html += '' + label.html() + ' : ';

                html += "</td>";
                html += "<td>";
                if ($(this).is("select"))
                    html += '<strong>' + $(this).find("option:selected").text() + '</strong>';
                else
                    html += '<strong>' + $(this).val() + '</strong>';
                html += "</td>";
                html += "</tr>";
            }
        });
    });
    html += "</table>";
    html += '</div>';
    html += '</div>';
    return html;
}

String.prototype.allReplace = function (obj) {
    var retStr = this;
    for (var x in obj) {
        retStr = retStr.replace(new RegExp(x, 'g'), obj[x]);
    }
    return retStr;
};

String.prototype.replaceAll = function (search, replacement) {
    var target = this;
    if (typeof search !== "undefined" && typeof replacement !== "undefined") {
        return target.split(search).join(replacement);
    } else {
        return true;
    }
};

String.prototype.replaceAll2 = function (str1, str2, ignore) {
    return this.replace(new RegExp(str1.replace(/([\/\,\!\\\^\$\{\}\[\]\(\)\.\*\+\?\|\<\>\-\&])/g, "\\$&"), (ignore ? "gi" : "g")), (typeof (str2) == "string") ? str2.replace(/\$/g, "$$$$") : str2);
}



jQuery(document.documentElement).keyup(function (event) {

    var owl = jQuery(".owl-carousel");

    if (owl.length) {
        if (event.keyCode == 37) {
            owl.trigger('prev.owl.carousel');
        } else if (event.keyCode == 39) {
            owl.trigger('next.owl.carousel');
        }
    }

    if (event.keyCode == 119) {
        event.preventDefault();
        window.location = '/processing/processing/ProcessView';
    }
    else if (event.keyCode == 120) {
        event.preventDefault();
        window.location = '/results/total';
    }
    else if (event.keyCode == 121) {
        event.preventDefault();
        window.location = '/results/export/';
    }

});