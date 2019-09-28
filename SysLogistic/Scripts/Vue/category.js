﻿var app = new Vue({
    el: '#app',
    data: {
        Id: 0,
        txtName: '',
        txtDescription: ''
        ,categories: []
    }, methods: {
        Save: function (event) {
            if (this.Id == 0) {
                this.SaveCategory(event);
            } else {
                this.UpdateCategory(event);
            }
        },
        SaveCategory: function (event) {
            axios.post("/Category/create", { Description: this.txtDescription, Name: this.txtName })
                .then(response => {
                    $('#modalCategory').modal('hide');
                    this.List();
                    this.CleanForm();
                });
        }
        , UpdateCategory: function (event) {
            axios.post("/Category/Update", { Name: this.txtName, Description: this.txtDescription, Id : this.Id })
                .then(response => {
                    $('#modalCategory').modal('hide');
                    this.List();
                    this.CleanForm();

                });
        }
        , List: function (event) {
            axios.get("/Category/List",
                {
                    dataType: 'json'
                })
                .then(response => this.categories = response.data.data);
        }, FindCategory: function (event) {
            $('#modalCategory').modal('show');
            this.MappingEntityToForm(event);
        }, MappingEntityToForm: function (event) {
            this.Id = event.Id;
            this.txtName = event.Name;
            this.txtDescription = event.Description;
        }, CleanForm: function(event) {
            this.Id = 0;
            this.txtName = '';
            this.txtDescription = '';
        }
        
    }, mounted() {
        this.List();
    }
});