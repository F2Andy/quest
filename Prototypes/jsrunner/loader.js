/* global quest */

(function () {
    window.quest = window.quest || {};
    
    var allowedVersions = [500, 510, 520, 530, 540, 550];
    
    var getAttribute = function (node, attributeName) {
        var attribute = node.attributes[attributeName];
        if (!attribute) return null;
        return attribute.value;
    };
    
    var loaders = {
        'game': function (node) {
            quest.create('game');
            var name = getAttribute(node, 'name');
            quest.set('game', 'name', name);
        },
        'function': function (node) {
            var paramList;
            var parameters = getAttribute(node, 'parameters');
            if (parameters) {
                paramList = parameters.split(/, ?/);
            }
            quest.addFunction(getAttribute(node, 'name'),
                quest.parseScript(node.textContent),
                paramList);
        }
    };
    
    quest.load = function (data) {
        var parser = new DOMParser();
        var doc = parser.parseFromString(data, 'application/xml');
        var firstNode = 0;
        for (var i = 0; i < doc.childNodes.length; i++) {
            if (doc.childNodes[i].nodeType === 1) {
                firstNode = i;
                break;
            }
        }
        var asl = doc.childNodes[firstNode];
        window.asl = asl;
        if (asl.nodeName !== 'asl') {
            throw 'File must begin with an ASL element';
        }
        var versionAttribute = asl.attributes['version'];
        if (!versionAttribute) {
            throw 'No ASL version number found';
        }
        var version = parseInt(versionAttribute.value);
        if (allowedVersions.indexOf(version) === -1) {
            throw 'Unrecognised ASL version number';
        }
        
        for (var i = 1; i < asl.childNodes.length; i++) {
            if (asl.childNodes[i].nodeType !== 1) continue;
            var loader = loaders[asl.childNodes[i].nodeName];
            if (loader) {
                loader(asl.childNodes[i]);
            }
            else {
                console.log('no loader for ' + asl.childNodes[i].nodeName);
            }
        }
        
        quest.dump();
    };
})();