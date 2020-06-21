<template>
  <div>
    <CForm @submit.prevent="submit">
      <CModal
        title="New Entity"
        size="xl"
        :closeOnBackdrop="false"
        :show.sync="showModal">

        <CAlert color="danger" :show.sync="serverError" closeButton>
          Oops! Something went wrong
        </CAlert>
        <CRow>
          <CCol sm="12">
            <CInput
              label="Text"
              :value.sync="form.text"
              :isValid="wasValidated ? validators.text : null"
              invalidFeedback="field is required"
              placeholder="type string..."
            />
          </CCol>
        </CRow>
        <CRow>
          <CCol sm="12">
            <CTextarea
              label="Textarea"
              :value.sync="form.multiline"
              :isValid="wasValidated ? validators.multiline : null"
              invalidFeedback="field is required"
              placeholder="Content..."
              rows="5"
            />
          </CCol>
        </CRow>
        <CRow>
          <CCol sm="6">
            <CSelect
              label="Select"
              :options="selectOptions"
              :isValid="wasValidated ? validators.select : null"
              invalidFeedback="field is required"
              placeholder="Select options..."
              :value.sync="form.select"
            />
          </CCol>
          <CCol sm="6">
            <CInput
              label="Date"
              :value.sync="form.date"
              :isValid="wasValidated ? validators.date : null"
              invalidFeedback="field is required"
              type="date"
            />
          </CCol>
        </CRow>
        <CRow>
          <CCol sm="6">
            <CInputRadioGroup
              class="col-sm-9"
              :options="options"
              :checked.sync="form.radio"
              inline
            />
            <div
              v-if="!validators.radio"
              class="invalid-feedback"
              style="display:unset"
            >
              field is required
            </div>
          </CCol>
          <CCol sm="6">
            <div class="input-group">
              <div
                class="form-check form-check-inline"
                v-for="(option, index) in checkOptions"
                :key="index"
              >
                <input
                  v-model="form.check"
                  class="form-check-input"
                  type="checkbox"
                  :value="option"
                />
                <label class="form-check-label" for="inlineCheckbox1">{{
                  option
                }}</label>
              </div>
              <div
                v-if="!validators.check"
                class="invalid-feedback"
                style="display:unset"
              >
                field is required
              </div>
            </div>
          </CCol>
        </CRow>
        <div slot="footer" class="w-100" style="text-align:end">
          <CButton
            type="reset"
            color="danger"
            variant="outline"
            @click="closeModal"
            style="margin-left:10px"
            >Cancel</CButton
          >
          <CButton
            type="submit"
            variant="outline"
            color="primary"
            style="margin-left:10px"
            >Submit</CButton
          >
        </div>
        <div slot="header" style="display:contents">
          <h5 class="modal-title">New Entity</h5>
          <CButton
            type="reset"
            aria-label="Close"
            class="close"
            variant="outline"
            @click="closeModal"
            style="margin-left:10px"
            >x</CButton
          >
        </div>
      </CModal>
    </CForm>
  </div>
</template>

<script lang="ts">
import Vue from 'vue'
import fetchApi from '../support/fetcher'

const initalForm = {
  select: null,
  text: null,
  date: null,
  multiline: null,
  radio: null,
  check: []
}

export const AddModal = Vue.extend({
  data () {
    return {
      selectOptions: [
        'Swift',
        'Java',
        'PHP',
        'Rust',
        'JavaScript',
        'Pyton',
        'Ruby',
        'Go'
      ],
      checkOptions: ['Check 1', 'Check 2', 'Check 3'],
      options: ['Option 1', 'Option 2', 'Option 3'],
      serverError: false,
      form: { ...initalForm },
      wasValidated: false,
      validators: {
        select: true,
        text: true,
        date: true,
        multiline: true,
        radio: true,
        check: true
      }
    }
  },
  props: {
    showModal: Boolean,
    value: [String, Number, Boolean, Array]
  },
  methods: {
    closeModal () {
      this.clearForm()
      this.$emit('close')
    },

    clearForm () {
      this.form = { ...initalForm }
      this.wasValidated = false
      this.serverError = false
    },

    async submit () {
      this.validate()
      if (Object.values(this.validators).some(value => !value)) {
        return
      }

      const { status } = await fetchApi(
        null,
        'api/EntityForm',
        'POST',
        JSON.stringify(this.form)
      )

      if (status !== 201) {
        this.serverError = true
        this.wasValidated = false
        return
      }
      this.clearForm()
      this.$emit('submit')
    },

    validate () {
      this.validators.select = !!this.form.select
      this.validators.text = !!this.form.text
      this.validators.multiline = !!this.form.multiline
      this.validators.radio = !!this.form.radio
      this.validators.date = !!this.form.date
      this.validators.check = !!this.form.check && this.form.check.length > 0

      this.wasValidated = true
    }
  }
})
export default AddModal
</script>

<style scoped>
.invalid-feedback {
  display: none;
  width: 100%;
  margin-top: 0.25rem;
  font-size: 80%;
  color: #dc3545;
}
</style>
