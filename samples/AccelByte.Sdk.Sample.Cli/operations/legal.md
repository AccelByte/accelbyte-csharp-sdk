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

### Operation OldRetrieveAcceptedAgreements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldretrieveacceptedagreements \
    --userId <userId value>
```

### Operation OldRetrieveAllUsersByPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldretrieveallusersbypolicyversion \
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

### Operation OldCreatePolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldcreatepolicy \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation OldRetrieveSinglePolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldretrievesinglepolicy \
    --basePolicyId <basePolicyId value>
```

### Operation OldPartialUpdatePolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldpartialupdatepolicy \
    --basePolicyId <basePolicyId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation OldRetrievePolicyCountry
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldretrievepolicycountry \
    --basePolicyId <basePolicyId value> \
    --countryCode <countryCode value>
```

### Operation OldRetrieveLocalizedPolicyVersions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldretrievelocalizedpolicyversions \
    --policyVersionId <policyVersionId value>
```

### Operation OldCreateLocalizedPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldcreatelocalizedpolicyversion \
    --policyVersionId <policyVersionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation OldRetrieveSingleLocalizedPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldretrievesinglelocalizedpolicyversion \
    --localizedPolicyVersionId <localizedPolicyVersionId value>
```

### Operation OldUpdateLocalizedPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldupdatelocalizedpolicyversion \
    --localizedPolicyVersionId <localizedPolicyVersionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation OldRequestPresignedURL
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldrequestpresignedurl \
    --localizedPolicyVersionId <localizedPolicyVersionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation OldSetDefaultLocalizedPolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldsetdefaultlocalizedpolicy \
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

### Operation RetrieveAcceptedAgreements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrieveacceptedagreements \
    --namespace <namespace value> \
    --userId <userId value> \
    --excludeOtherNamespacesPolicies <excludeOtherNamespacesPolicies value - optional>
```

### Operation RetrieveAllUsersByPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrieveallusersbypolicyversion \
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

### Operation CreatePolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op createpolicy \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrieveSinglePolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievesinglepolicy \
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

### Operation PartialUpdatePolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op partialupdatepolicy \
    --basePolicyId <basePolicyId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrievePolicyCountry
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievepolicycountry \
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

### Operation RetrieveLocalizedPolicyVersions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievelocalizedpolicyversions \
    --namespace <namespace value> \
    --policyVersionId <policyVersionId value>
```

### Operation CreateLocalizedPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op createlocalizedpolicyversion \
    --namespace <namespace value> \
    --policyVersionId <policyVersionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrieveSingleLocalizedPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievesinglelocalizedpolicyversion \
    --localizedPolicyVersionId <localizedPolicyVersionId value> \
    --namespace <namespace value>
```

### Operation UpdateLocalizedPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op updatelocalizedpolicyversion \
    --localizedPolicyVersionId <localizedPolicyVersionId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RequestPresignedURL
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op requestpresignedurl \
    --localizedPolicyVersionId <localizedPolicyVersionId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SetDefaultLocalizedPolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op setdefaultlocalizedpolicy \
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

### Operation UpdatePolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op updatepolicyversion \
    --namespace <namespace value> \
    --policyVersionId <policyVersionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublishPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op publishpolicyversion \
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

### Operation UpdatePolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op updatepolicy \
    --namespace <namespace value> \
    --policyId <policyId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SetDefaultPolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op setdefaultpolicy \
    --namespace <namespace value> \
    --policyId <policyId value>
```

### Operation RetrieveSinglePolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievesinglepolicyversion \
    --namespace <namespace value> \
    --policyId <policyId value> \
    --versionId <versionId value - optional>
```

### Operation CreatePolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op createpolicyversion \
    --namespace <namespace value> \
    --policyId <policyId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrieveAllPolicyTypes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrieveallpolicytypes \
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

### Operation OldUpdatePolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldupdatepolicyversion \
    --policyVersionId <policyVersionId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation OldPublishPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldpublishpolicyversion \
    --policyVersionId <policyVersionId value> \
    --shouldNotify <shouldNotify value - optional>
```

### Operation OldUpdatePolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldupdatepolicy \
    --policyId <policyId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation OldSetDefaultPolicy
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldsetdefaultpolicy \
    --policyId <policyId value>
```

### Operation OldRetrieveSinglePolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldretrievesinglepolicyversion \
    --policyId <policyId value> \
    --versionId <versionId value - optional>
```

### Operation OldCreatePolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldcreatepolicyversion \
    --policyId <policyId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation OldRetrieveAllPolicyTypes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldretrieveallpolicytypes \
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

### Operation PublicChangePreferenceConsent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op publicchangepreferenceconsent \
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

### Operation OldPublicRetrieveSingleLocalizedPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldpublicretrievesinglelocalizedpolicyversion \
    --localizedPolicyVersionId <localizedPolicyVersionId value>
```

### Operation PublicRetrieveSingleLocalizedPolicyVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op publicretrievesinglelocalizedpolicyversion \
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

### Operation OldRetrieveLatestPoliciesByNamespaceAndCountryPublic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op oldretrievelatestpoliciesbynamespaceandcountrypublic \
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

### Operation RetrieveLatestPoliciesByNamespaceAndCountryPublic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn legal \
    --op retrievelatestpoliciesbynamespaceandcountrypublic \
    --countryCode <countryCode value> \
    --namespace <namespace value> \
    --clientId <clientId value>
```

