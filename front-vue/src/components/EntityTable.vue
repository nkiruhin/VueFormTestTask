<template>
    <CCardBody>
        <CDataTable :items="items"
                    :fields="fields"
                    items-per-page-select
                    :items-per-page="10"
                    size="sm"
                    sorter
                    pagination>
        </CDataTable>
        <CElementCover v-if="!refresh" :boundaries="[{ sides: ['top', 'left'], query: '.media-body' }]"
                       :opacity="0.8">
            <h4 class="d-inline">Loading... </h4>
            <CSpinner size="5xl" color="success" />
        </CElementCover>
    </CCardBody>
</template>

<script lang='ts'>
import Vue from 'vue'
import fetchApi from '../support/fetcher'

        interface Iitem {
            entityId: string;
            fields: {
                select: string;
                text: string;
                date: string;
                multiline: string;
                radio: string;
                check: string[];
            };
        }

const fields = [
  { key: 'text', _style: 'width:20%' },
  'multiline',
  { key: 'select', _style: 'width:7%;' },
  { key: 'date', _style: 'width:10%;' },
  { key: 'radio', _style: 'width:7%;' },
  { key: 'check', _style: 'width:10%;' },
  {
    key: 'show_details',
    label: '',
    _style: 'width:1%',
    sorter: false,
    filter: false
  }
]

export const EntityTable = Vue.extend({
  name: 'EntityTable',
  data () {
    return {
      items: [],
      fields,
      details: [],
      collapseDuration: 0,
      errors: {
        name: null,
        birthdate: null,
        sity: null,
        bio: null,
        hobby: null,
        sex: null
      }
    }
  },
  props: {
    refresh: Boolean,
    searchText: String
  },
  created () {
    this.getData(this.searchText)
  },
  updated () {
    if (!this.refresh) {
      this.getData(this.searchText)
    }
    this.$emit('refresh')
  },

  methods: {
    async getData (searchText: string) {
      const { data, status } = await fetchApi(
        null,
                            `api/EntityForm/${searchText}`,
                            'GET'
      )
      this.items = data.map((entity: Iitem) => {
        return { ...entity.fields, entityId: entity.entityId }
      })
    }
  }
})
export default EntityTable
</script>

    <!-- Add 'scoped' attribute to limit CSS to this component only -->
    (scoped as style)>(/style> as )
