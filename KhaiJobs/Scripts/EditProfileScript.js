var arrQuality = [
    "Аккуратность", "Активность", "Амбициозность", "Бесконфликтность", "Быстрая реакция", "Вежливость", "Внимательность", "Дисциплинированность",
    "Инициативность", "Исполнительность", "Коммуникабельность", "Максимализм", "Настойчивость", "Находчивость", "Обаяние",
    "Организованность", "Ответсвенность", "Порядочность", "Преданность", "Принципиальность", "Пунктуальность", "Решительность",
    "Самоконтроль", "Самокритичность", "Самостоятельность", "Скромность", "Стрессоустойчивость", "Тактичность", "Терпеливость",
    "Требовательность", "Трудолюбие", "Уверенность в себе", "Уравновешенность", "Целеустремленность", "Честность", "Энергичность", "Этичность"
];

document.addEventListener("DOMContentLoaded", ready);

$(document).ready(function () {
    $(".testrat").each(function (item) {
        $(item).raty({
            score: arr[k - 1].score,
            numberMax: 5,
            readOnly: true
        });
    });
});

function ready() {
    //setTimeout(updtime, 1000);
    var j = 0;
    var arrayTest = ["один", "два", "три", "пять", "десять"];
    arrayTest.forEach(function (item) {
        var idforcode = item.replace(/\s{1,}/g, '').replace(/[-()/\\]/g, '').replace(/\#/g, '-sh').replace(/\+/g, '-pl');
        $("#table-qual").append('<tr>' +
            '<td class="skill_name">' + item + '</td>' +
            '<td>' +
            '<div id="' + item.replace(/\s{1,}/g, '') + '"></div>' +
            '<input type="hidden" name="competition[\'' + item.replace(/\s{1,}/g, '') + '\']" id="' + idforcode + 'hide" value="1" />' +
            ' </td> <td class="skill-remove"><a href="#">×</a></td> </tr>'
        );
        j++;
        var code = '$("#' + idforcode + '").raty({numberMax: 5,target:  "#' + idforcode + 'hide",readOnly:true,score:' + j + '});';
        console.log(code);
        eval(code);
    });

    $(document).on('click', '.skill-remove > a', function () {
        $(this).parents('tr').fadeOut(100, function () {
            $(this).remove();
            /* $.post(window.location.href,
                 {
                     delete_skill: this.id
                     //csrfmiddlewaretoken: 'Rxd89plwJZRqCX3qJ9nQ7hbSQb0ZWMuEvTTgkhmlb5KJWvYdN4liWlufJtoCNMkz'
                 },
                 function (data, status) {
                     $(this).remove();
                 })
                 .fail(function (xhr) {
                     //console.log("Can’t remove. Reason: " + xhr.statusText);
                 });
             */
        });
        return false;
    });


    $("#drop-quality").on('click', 'li a', function (event) {
        event.preventDefault();
        document.getElementById("drop-quality").style.display = "none";
        //console.log(this.innerHTML);
        var textqual = this.innerHTML;
        AddItemToTable("table-qual", "quality", textqual);
    });

    $('#btn-qual-add').on('click', function (event) {
        event.preventDefault();
        var textqual = $('#quality').val();
        if (textqual != "") {
            AddItemToTable("table-qual", "quality", textqual);
        }
    });


    var tmp = 1;
    function AddItemToTable(tblName, inputEl, text) {
        var tbl = $("#" + tblName);
        if (tbl[0].children.length != 0) {

            var listQuantyties = tbl[0].children[0].children;
            var flagExist = false;
            for (var i = 0; i < listQuantyties.length; i++) {

                console.log(listQuantyties[i].children[0].innerHTML);
                if (listQuantyties[i].children[0].innerHTML == text) {

                    flagExist = true;
                }
            }
        }
        $("#" + inputEl).val("");
        //var idforcode = text.replace(/\s{1,}/g, '').replace(/\(/g, 'sc-o').replace(/\)/g, 'sc-c').replace(/[()/\\]/g, '').replace(/\#/g, '-sh').replace(/\+/g, '-pl');
        var idforcode = "";
        if (!flagExist)
            $("#" + tblName).append('<tr>' +
                '<td class="skill_name">' + text + '</td>' +
                '<td>' +
                '<div id="tmpUtem' + tmp + '" class="qualityone"></div>' +
                '<input type="hidden" name="competition[\'' + text + '\']" id="' + idforcode + 'hide" value="1" />' +
                ' </td> <td class="skill-remove"><a href="#">×</a></td> </tr>'
            );
        var code = '$("#tmpUtem' + tmp + '").raty({score: 1,numberMax: 5,click: function(score, evt){this.nextSibling.value=score}});';
        console.log(code);
        eval(code);
        tmp++;
        return false;
    }

    $("#quality").on('keyup', function () {
        var inp = this.value;
        UpdateList("drop-quality", inp, arrQuality);
    });

    function UpdateList(nameDrop, inp, arrayList) {
        var natEl = document.getElementById(nameDrop);
        natEl.style.display = "none";
        if (inp.length >= 1) {
            var jqEl = $("#" + nameDrop);
            jqEl.empty();
            var count = 0;
            arrayList.forEach(function (item) {

                if (item.toLowerCase().indexOf(inp.toLowerCase()) != -1) {
                    //console.log("Sussess! " + item);
                    count++;
                    if (count < 10) {
                        jqEl.append('<li><a href="#">' + item + '</a></li>');
                    }

                }

            });

            if (count > 0) { natEl.style.display = "block"; }
        }
    }

}