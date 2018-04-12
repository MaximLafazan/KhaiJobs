document.addEventListener("DOMContentLoaded", ready);

// этот массив должен подгружатся из БД


var ArraySkills = ["Умение решать задачи", "Аналитический склад ума", "Упорство", "Умение работать в команде", "Хорошая концентрация", "Усидчивость", "Алгоритмизированный подход", "Ответственность", "Коммуникабельность", "Инициативность"];

var ArrayKnow = ["Action Script", "C++/CLI", "C++", "ColdFusion", "D", "Delphi", "Dylan", "Eiffel", "Game Maker Language (GML)", "Groovy", "haXe", "Io", "Java", "JavaScript", "MC#", "Object Pascal", "Objective-C", "Perl", "PHP", "Pike", "Python", "Ruby", "Self", "Simula", "Smalltalk", "Swift", "Vala", "Visual Basic", "Visual DataFlex", "Zonnon", "Ada", "Активный Оберон", "Модула-3", "Оберон-2", "C#", "Curry", "Delphi (язык программирования)", "Erlang", "Mathematica", "Mozart", "Nemerle", "Python", "Scala", "Zonnon", "Компонентный Паскаль (Component Pascal)", "Swift"];

var ArrayAbility = ["Умение один", "Умение два"];

function ready() {
    //setTimeout(updtime, 1000);

    /*
    $("#testrate").raty({
        score: 1,
        numberMax: 5,
        target: "#" + this.id + "hide",
        click: function (score, evt) {
            //alert('ID: ' + this.id + "\nscore: " + score + "\nevent: " + evt);
            $("#" + this.id + "hide").val(score);
            alert(document.getElementById(this.id + "hide").value);
        }

    });
    */

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




    $("#drop-skill").on('click', 'li a', function (event) {
        event.preventDefault();
        document.getElementById("drop-skill").style.display = "none";
        var textskill = this.innerHTML;
        AddItemToTable("table-skill", "skill", textskill);
    });
    $("#drop-knowledge").on('click', 'li a', function (event) {
        event.preventDefault();
        document.getElementById("drop-knowledge").style.display = "none";
        var textknow = this.innerHTML;
        AddItemToTable("table-know", "knowledge", textknow);

    });
    $("#drop-ability").on('click', 'li a', function (event) {
        event.preventDefault();
        document.getElementById("drop-ability").style.display = "none";
        var textknow = this.innerHTML;
        AddItemToTable("table-ability", "ability", textknow);

    });

    $('#btn-know-add').on('click', function () {
        event.preventDefault();
        var textknow = $('#knowledge').val();
        if (textknow != "") {
            AddItemToTable("table-know", "knowledge", textknow);
        }
    });
    $('#btn-skill-add').on('click', function () {
        event.preventDefault();
        var textskill = $('#skill').val();
        if (textskill != "") {
            AddItemToTable("table-skill", "skill", textskill);
        }
    });

    $('#btn-ability-add').on('click', function () {
        event.preventDefault();
        var textability = $('#ability').val();
        if (textability != "") {
            AddItemToTable("table-ability", "ability", textability);
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
        //console.log(code);
        eval(code);
        tmp++;
        return false;
    }

    $("#skill").on('keyup', function () {
        var inp = this.value;
        UpdateList("drop-skill", inp, ArraySkills);
    });

    $("#ability").on('keyup', function () {
        var inp = this.value;
        UpdateList("drop-ability", inp, ArrayAbility);
    });

    $("#knowledge").on('keyup', function () {
        //console.log(this.value);
        var inp = this.value;
        UpdateList("drop-knowledge", inp, ArrayKnow);
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




};
