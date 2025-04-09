## C# Extend SDK CLI Sample App Operation Index for Legal service.

### Operation ChangePreferenceConsent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op changepreferenceconsent \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrieveAcceptedAgreements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrieveacceptedagreements \
    --userId <userId value>
```

### Operation RetrieveAllUsersByPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrieveallusersbypolicyversion \
    --keyword <keyword value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --policyVersionId <policyVersionId value>
```

### Operation RetrieveAllLegalPolicies
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievealllegalpolicies \
    --visibleOnly <visibleOnly value - optional>
```

### Operation CreatePolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op createpolicy \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrieveSinglePolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievesinglepolicy \
    --basePolicyId <basePolicyId value>
```

### Operation PartialUpdatePolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op partialupdatepolicy \
    --basePolicyId <basePolicyId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrievePolicyCountry
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievepolicycountry \
    --basePolicyId <basePolicyId value> \
    --countryCode <countryCode value>
```

### Operation RetrieveLocalizedPolicyVersions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievelocalizedpolicyversions \
    --policyVersionId <policyVersionId value>
```

### Operation CreateLocalizedPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op createlocalizedpolicyversion \
    --policyVersionId <policyVersionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrieveSingleLocalizedPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievesinglelocalizedpolicyversion \
    --localizedPolicyVersionId <localizedPolicyVersionId value>
```

### Operation UpdateLocalizedPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op updatelocalizedpolicyversion \
    --localizedPolicyVersionId <localizedPolicyVersionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RequestPresignedURL
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op requestpresignedurl \
    --localizedPolicyVersionId <localizedPolicyVersionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SetDefaultPolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op setdefaultpolicy \
    --localizedPolicyVersionId <localizedPolicyVersionId value>
```

### Operation RetrieveAcceptedAgreementsForMultiUsers
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrieveacceptedagreementsformultiusers \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrieveAcceptedAgreements1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrieveacceptedagreements1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --excludeOtherNamespacesPolicies <excludeOtherNamespacesPolicies value - optional>
```

### Operation RetrieveAllUsersByPolicyVersion1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrieveallusersbypolicyversion1 \
    --namespace <namespace value> \
    --convertGameUserId <convertGameUserId value - optional> \
    --keyword <keyword value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --policyVersionId <policyVersionId value>
```

### Operation DownloadExportedAgreementsInCSV
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op downloadexportedagreementsincsv \
    --namespace <namespace value> \
    --exportId <exportId value>
```

### Operation InitiateExportAgreementsToCSV
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op initiateexportagreementstocsv \
    --namespace <namespace value> \
    --end <end value - optional> \
    --policyVersionId <policyVersionId value> \
    --start <start value>
```

### Operation RetrieveAllLegalPoliciesByNamespace
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievealllegalpoliciesbynamespace \
    --namespace <namespace value> \
    --visibleOnly <visibleOnly value - optional>
```

### Operation CreatePolicy1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op createpolicy1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrieveSinglePolicy1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievesinglepolicy1 \
    --basePolicyId <basePolicyId value> \
    --namespace <namespace value>
```

### Operation DeleteBasePolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op deletebasepolicy \
    --basePolicyId <basePolicyId value> \
    --namespace <namespace value>
```

### Operation PartialUpdatePolicy1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op partialupdatepolicy1 \
    --basePolicyId <basePolicyId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrievePolicyCountry1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievepolicycountry1 \
    --basePolicyId <basePolicyId value> \
    --countryCode <countryCode value> \
    --namespace <namespace value>
```

### Operation RetrieveAllPoliciesFromBasePolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrieveallpoliciesfrombasepolicy \
    --basePolicyId <basePolicyId value> \
    --namespace <namespace value>
```

### Operation CreatePolicyUnderBasePolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op createpolicyunderbasepolicy \
    --basePolicyId <basePolicyId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteLocalizedPolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op deletelocalizedpolicy \
    --localizedPolicyVersionId <localizedPolicyVersionId value> \
    --namespace <namespace value>
```

### Operation RetrieveLocalizedPolicyVersions1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievelocalizedpolicyversions1 \
    --namespace <namespace value> \
    --policyVersionId <policyVersionId value>
```

### Operation CreateLocalizedPolicyVersion1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op createlocalizedpolicyversion1 \
    --namespace <namespace value> \
    --policyVersionId <policyVersionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrieveSingleLocalizedPolicyVersion1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievesinglelocalizedpolicyversion1 \
    --localizedPolicyVersionId <localizedPolicyVersionId value> \
    --namespace <namespace value>
```

### Operation UpdateLocalizedPolicyVersion1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op updatelocalizedpolicyversion1 \
    --localizedPolicyVersionId <localizedPolicyVersionId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RequestPresignedURL1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op requestpresignedurl1 \
    --localizedPolicyVersionId <localizedPolicyVersionId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SetDefaultPolicy1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op setdefaultpolicy1 \
    --localizedPolicyVersionId <localizedPolicyVersionId value> \
    --namespace <namespace value>
```

### Operation DeletePolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op deletepolicyversion \
    --namespace <namespace value> \
    --policyVersionId <policyVersionId value>
```

### Operation UpdatePolicyVersion1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op updatepolicyversion1 \
    --namespace <namespace value> \
    --policyVersionId <policyVersionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublishPolicyVersion1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op publishpolicyversion1 \
    --namespace <namespace value> \
    --policyVersionId <policyVersionId value> \
    --shouldNotify <shouldNotify value - optional>
```

### Operation UnpublishPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op unpublishpolicyversion \
    --namespace <namespace value> \
    --policyVersionId <policyVersionId value>
```

### Operation DeletePolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op deletepolicy \
    --namespace <namespace value> \
    --policyId <policyId value>
```

### Operation UpdatePolicy1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op updatepolicy1 \
    --namespace <namespace value> \
    --policyId <policyId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SetDefaultPolicy3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op setdefaultpolicy3 \
    --namespace <namespace value> \
    --policyId <policyId value>
```

### Operation RetrieveSinglePolicyVersion1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievesinglepolicyversion1 \
    --namespace <namespace value> \
    --policyId <policyId value> \
    --versionId <versionId value - optional>
```

### Operation CreatePolicyVersion1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op createpolicyversion1 \
    --namespace <namespace value> \
    --policyId <policyId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrieveAllPolicyTypes1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrieveallpolicytypes1 \
    --namespace <namespace value> \
    --offset <offset value - optional> \
    --limit <limit value>
```

### Operation IndirectBulkAcceptVersionedPolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op indirectbulkacceptversionedpolicy \
    --namespace <namespace value> \
    --userId <userId value> \
    --publisherUserId <publisherUserId value - optional> \
    --clientId <clientId value> \
    --countryCode <countryCode value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminRetrieveEligibilities
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op adminretrieveeligibilities \
    --namespace <namespace value> \
    --userId <userId value> \
    --publisherUserId <publisherUserId value - optional> \
    --clientId <clientId value> \
    --countryCode <countryCode value>
```

### Operation RetrievePolicies
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievepolicies \
    --countryCode <countryCode value>
```

### Operation UpdatePolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op updatepolicyversion \
    --policyVersionId <policyVersionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublishPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op publishpolicyversion \
    --policyVersionId <policyVersionId value> \
    --shouldNotify <shouldNotify value - optional>
```

### Operation UpdatePolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op updatepolicy \
    --policyId <policyId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SetDefaultPolicy2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op setdefaultpolicy2 \
    --policyId <policyId value>
```

### Operation RetrieveSinglePolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievesinglepolicyversion \
    --policyId <policyId value> \
    --versionId <versionId value - optional>
```

### Operation CreatePolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op createpolicyversion \
    --policyId <policyId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrieveAllPolicyTypes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrieveallpolicytypes \
    --offset <offset value - optional> \
    --limit <limit value>
```

### Operation GetUserInfoStatus
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op getuserinfostatus \
    --namespaces <namespaces value - optional>
```

### Operation AnonymizeUserAgreement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op anonymizeuseragreement \
    --userId <userId value>
```

### Operation ChangePreferenceConsent1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op changepreferenceconsent1 \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AcceptVersionedPolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op acceptversionedpolicy \
    --localizedPolicyVersionId <localizedPolicyVersionId value>
```

### Operation RetrieveAgreementsPublic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrieveagreementspublic \

```

### Operation BulkAcceptVersionedPolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op bulkacceptversionedpolicy \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrieveEligibilitiesPublic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrieveeligibilitiespublic \
    --namespace <namespace value>
```

### Operation RetrieveEligibilitiesPublicIndirect
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrieveeligibilitiespublicindirect \
    --clientId <clientId value> \
    --countryCode <countryCode value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation RetrieveSingleLocalizedPolicyVersion2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievesinglelocalizedpolicyversion2 \
    --localizedPolicyVersionId <localizedPolicyVersionId value>
```

### Operation RetrieveSingleLocalizedPolicyVersion3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievesinglelocalizedpolicyversion3 \
    --localizedPolicyVersionId <localizedPolicyVersionId value> \
    --namespace <namespace value>
```

### Operation RetrieveCountryListWithPolicies
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievecountrylistwithpolicies \

```

### Operation RetrieveLatestPolicies
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievelatestpolicies \
    --countryCode <countryCode value> \
    --defaultOnEmpty <defaultOnEmpty value - optional> \
    --policyType <policyType value - optional> \
    --tags <tags value - optional> \
    --visibleOnly <visibleOnly value - optional>
```

### Operation RetrieveLatestPoliciesPublic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievelatestpoliciespublic \
    --namespace <namespace value> \
    --alwaysIncludeDefault <alwaysIncludeDefault value - optional> \
    --defaultOnEmpty <defaultOnEmpty value - optional> \
    --policyType <policyType value - optional> \
    --tags <tags value - optional> \
    --visibleOnly <visibleOnly value - optional>
```

### Operation RetrieveLatestPoliciesByNamespaceAndCountryPublic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievelatestpoliciesbynamespaceandcountrypublic \
    --countryCode <countryCode value> \
    --namespace <namespace value> \
    --alwaysIncludeDefault <alwaysIncludeDefault value - optional> \
    --defaultOnEmpty <defaultOnEmpty value - optional> \
    --policyType <policyType value - optional> \
    --tags <tags value - optional> \
    --visibleOnly <visibleOnly value - optional>
```

### Operation CheckReadiness
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op checkreadiness \

```

### Operation RetrieveLatestPoliciesByNamespaceAndCountryPublic1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievelatestpoliciesbynamespaceandcountrypublic1 \
    --countryCode <countryCode value> \
    --namespace <namespace value> \
    --clientId <clientId value>
```

