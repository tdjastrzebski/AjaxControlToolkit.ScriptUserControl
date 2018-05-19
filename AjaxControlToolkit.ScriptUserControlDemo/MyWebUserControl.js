// author: Tomasz Jastrzębski

// register the namespace for the control
Type.registerNamespace('AjaxControlToolkit.ScriptUserControlDemo');

//
// define the control properties
//
AjaxControlToolkit.ScriptUserControlDemo.MyWebUserControl = function (element) {
    AjaxControlToolkit.ScriptUserControlDemo.MyWebUserControl.initializeBase(this, [element]);

    this._panelID = null;
}

//
// create the prototype for the control
//
AjaxControlToolkit.ScriptUserControlDemo.MyWebUserControl.prototype = {
    initialize: function () {
        AjaxControlToolkit.ScriptUserControlDemo.MyWebUserControl.callBaseMethod(this, 'initialize');
    },

    dispose: function () {
        AjaxControlToolkit.ScriptUserControlDemo.MyWebUserControl.callBaseMethod(this, 'dispose');
    },

    get_panelID: function () {
        return this._panelID;
    },

    set_panelID: function (value) {
        if (this._panelID !== value) {
            this._panelID = value;
            this.raisePropertyChanged('panelID');
        }
    },

    //
    // IClientStateManager
    //
    saveClientState: function () {
        var location = Sys.UI.DomElement.getLocation($get(this.get_panelID()));
        var state = {
            X: location.x,
            Y: location.y
        };
        var payload = Sys.Serialization.JavaScriptSerializer.serialize(state);
        if (this._clientStateField) this._clientStateField.value = payload;
        return payload;
    },

    loadClientState: function (value) {
        var location = Sys.Serialization.JavaScriptSerializer.deserialize(value);
        if (location != null) {
            if (location.X != 0 || location.Y != 0) {
                // restore position if location was previously stored
                Sys.UI.DomElement.setLocation($get(this.get_panelID()), location.X, location.Y);
            }
        }
    }
}

AjaxControlToolkit.ScriptUserControlDemo.MyWebUserControl.registerClass('AjaxControlToolkit.ScriptUserControlDemo.MyWebUserControl', Sys.Extended.UI.ControlBase);