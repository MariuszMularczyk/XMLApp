<template>
    <div>
        <br />
        <br />
        <h1 style="text-align:center">Menu</h1>
        <br />
        <div class="list-buttons">
            <input type="file" ref="fileupload" @change="handleFileUpload($event)" accept="text/xml" />
        </div>
        <item-list style=" margin-bottom: 20px" v-for="product of getProductsList()" :key="`product-${product.id}`" :item="product" @editItem="editItem" @deleteItem="deleteProduct"></item-list>
        <br />
        <br />
    </div>
</template>

<script>
    import router from '@/router/index';
    import { mapActions, mapGetters } from 'vuex';
    const name = "productStore/indexStore";
    import ItemList from "@/components/ItemList"

    export default {
        name: "ProductsList",
        data() {
            return {
            }
        },
        computed: {
        },
        methods: {
            ...mapActions(name, ['setProductsList', 'deleteProduct', 'addProducts']),
            ...mapGetters(name, ['getProductsList']),
            editItem(e) {
                router.push({ name: 'product.edit', params: { id: e } });
            },
            handleFileUpload(e) {
                console.log('test');
                let form = new FormData();
                form.append('file', e.target.files[0]);
                this.addProducts(form).then(() => this.$refs.fileupload.value = null);

            },

        },
        mounted() {
            this.setProductsList();
        },
        components: {
            ItemList
        }
    }
</script>

<style scoped lang="sass">
    .list-buttons
        margin-bottom: 20px
        margin-left: 5%;
        .name-column
            width: 100px

        .buttons-column
            display: flex
            flex-direction: row
            button
                margin-left: 10px
</style>
