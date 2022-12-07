<template>
    <form role="form" @submit.prevent="editProductValidation">
        <br />
        <div v-if="this.validation">
            <h2 style="color: red">Musisz wypełnić wszystkie pola aby edytować produkt!</h2>
        </div>
        <div class="form-group">
            <label for="name">Nazwa</label>
            <input type="text" v-model="Name" class="form-control" id="name">
        </div>

        <div class="form-group">
            <label for="description" class="control-label">Opis</label>
            <textarea v-model="Description" id="description" class="form-control"></textarea>
        </div>
        <div class="form-group">
            <label for="price" class="control-label">Cena</label>
            <input v-model="Price" id="price" class="form-control">
        </div>
        <div class="form-group">
            <label for="calories" class="control-label">Kalorie</label>
            <input type="number" v-model="Calories" id="calories" class="form-control">
        </div>
        <button type="submit" class="btn btn-primary">Zapisz</button>
        <router-link :to="{name: 'productList'}"><button type="default" class="btn btn-primary" style="margin-left: 20px;">Wróć</button></router-link>
        <br />
        <br />
    </form>
</template>

<script>
    import { mapActions } from "vuex";
    import { mapFields } from 'vuex-map-fields';
    const name = "productStore/editStore";
    
    export default {
        name: "ProductEdit",
        data() {
            return {
                validation: false
            }
        },
        computed: {
            ...mapFields(name, ['Product.Name', 'Product.Description', 'Product.Price', 'Product.Calories',]),
        },
        methods: {
            ...mapActions(name,['setProductForm','editProduct']),

            editProductValidation() {
                if (this.Name == '' || this.Description == '' || this.Calories == 0 || this.Price == '' ) {
                    this.validation = true
                }
                else {
                    this.editProduct();
                }
            }
        },
        mounted() {
            this.setProductForm();         
        },
        components: {
        },
    }
</script>

<style scoped>
</style>