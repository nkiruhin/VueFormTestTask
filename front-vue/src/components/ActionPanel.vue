<template>
 <CRow style="margin:20px 15px 0px 15px">
     <add-modal
     :showModal="showModal"
     @close="onClose" @submit="onSubmit" />

     <CCol sm="8">
      <CButton
        @click="showModal = true"
        color="primary"
        shape="square"
        variant="outline" >
        Add Entity
      </CButton>
    </CCol>

    <CCol sm="4" alignHorizontal="end">
        <search @go="onSearch" />
    </CCol>

     <entity-table :refresh="refresh"
                  @refresh="onRefresh"
                  :searchText="searchText" />
    </CRow>
</template>

<script lang='ts'>
import Vue from 'vue'
import AddModal from './AddModal.vue'
import EntityTable from './EntityTable.vue'
import Search from './Search.vue'

const ActionPanel = Vue.extend({
  data () {
    return {
      showModal: false,
      refresh: true,
      searchText: ''
    }
  },
  components: {
    AddModal,
    Search,
    EntityTable
  },
  methods: {
    onClose () {
      this.showModal = false
    },
    onSearch ({ searchText }: { searchText: string }) {
      this.searchText = searchText
      this.refresh = false
    },
    onSubmit () {
      this.showModal = false
      this.refresh = false
    },
    onRefresh () {
      this.refresh = true
    }
  }
})

export default ActionPanel
</script>

    <style scoped></style>
